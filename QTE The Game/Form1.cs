using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WMPLib;
namespace QTE_The_Game
{
    public partial class InsaneBlockRunner : Form
    {
        int clockMax = 2;
        WindowsMediaPlayer menuMusic = new WMPLib.WindowsMediaPlayer();
        Button[] First = new Button[16];
        Button[] Second = new Button[16];
        Button[] Third = new Button[16];
        Button[] Fourth = new Button[16];
        Button[] Fifth = new Button[16];
        Random randomTrap = new Random();
        bool jump = false, land = false, jump2 = false, land2 = false;
        bool lost = false, fatigue = false, danger=false;
        bool prepare = false, smash=false, first=false;
        int smashCount=0;
        int empty=0, multiplier=1, score=0, clock=0;
        private System.Timers.Timer t;
        Color ColorBackGround = new Color();
        Color ColorPlayer = new Color();
        Color ColorBadGuyHead = new Color();
        Color ColorBadGuyBody = new Color();
        Color ColorBarrier = new Color();
        Color ColorDoor = new Color();
        Color ColorWalls = new Color();
        string[] colorScheme = new string[] { "Mirrors Revenge", "Frozen Syntax", "Woof Among Us", "Modern Pew Pew Eew", "Sesory Overload" };
        string[] difficulty = new string[] { "Easy", "Medium", "Hard", "Insane" };

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void Interval(object s, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (fatigue)
                {
                    fatigue = false;
                }
                if (land)
                {
                    if (land2)
                    {
                        land2 = false;
                        fatigue = true;
                    }
                    if (Fourth[3].BackColor == ColorBarrier) { land2 = true; fatigue = true; }
                    else
                    {
                        Fourth[3].BackColor = ColorPlayer;
                        Third[3].BackColor = ColorBackGround;
                        land = false;
                        fatigue = true;
                    }
                }

                if (jump2) { jump2 = false; land = true; }
                if (jump && fatigue == false)
                {
                    Fourth[3].BackColor = ColorBackGround;
                    Third[3].BackColor = ColorPlayer;
                    jump2 = true;
                    jump = false;

                }

                clock++;
                if (smashCount > 0 && clock > clockMax)
                {
                    smashCount--; progressBar1.Value = smashCount; clock = 0;
                    if (smashCount > 4) smash = true;
                    else smash = false;

                }


                for (int i = 0; i < 16; i++)
                {
                    if (i + 1 < 16)
                    {
                        if (Fourth[3].BackColor == ColorBarrier && danger) { score++; danger = false; }
                        else if (Fifth[3].BackColor == ColorBackGround && danger) { score++; danger = false; }
                        else if (Third[3].BackColor == ColorBarrier && danger) { score++; danger = false; }
                        First[i].BackColor = First[i + 1].BackColor;
                        Second[i].BackColor = Second[i + 1].BackColor;

                        if (Fourth[i + 1].BackColor == ColorBadGuyBody && Fourth[i].BackColor == ColorPlayer && lost == false) { lost = true; }
                        if (Third[i].BackColor == ColorPlayer && Fourth[i + 1].BackColor == ColorBadGuyBody && lost == false) { lost = true; }

                        if (Fourth[i].BackColor == ColorPlayer && Fourth[i + 1].BackColor == ColorBarrier && lost == false) { lost = true; }
                        else { if (Fourth[i].BackColor == ColorPlayer)Fourth[i - 1].BackColor = Fourth[i + 1].BackColor; }

                        if (Fourth[i].BackColor == ColorPlayer && Fourth[i + 1].BackColor == ColorDoor && lost == false && smash == false) { lost = true; }
                        else { if (Fourth[i].BackColor == ColorPlayer)Fourth[i - 1].BackColor = Fourth[i + 1].BackColor; if (Fourth[i].BackColor == ColorPlayer && Fourth[i + 1].BackColor == ColorDoor) { pbx_alert.Visible = false; progressBar1.Visible = false;} }

                        if (Third[i].BackColor == ColorPlayer && Third[i + 1].BackColor == ColorBarrier && lost == false) { lost = true; }
                        else { if (Third[i].BackColor == ColorPlayer)Third[i - 1].BackColor = Third[i + 1].BackColor; }


                        if (Third[i].BackColor != ColorPlayer && Third[i + 1].BackColor != ColorPlayer) Third[i].BackColor = Third[i + 1].BackColor;
                        if (Fourth[i].BackColor != ColorPlayer && Fourth[i + 1].BackColor != ColorPlayer) Fourth[i].BackColor = Fourth[i + 1].BackColor;
                        Fifth[i].BackColor = Fifth[i + 1].BackColor;
                        if (Fourth[i].BackColor == ColorPlayer && Fifth[i].BackColor == ColorBackGround) { lost = true; Fifth[i].BackColor = ColorPlayer; Fourth[i].BackColor = ColorBackGround; }
                    }
                }
                if (lost)
                {
                    b_start.Text = "Restart";
                    gbx_game.Enabled = true;
                    cbx_colorScheme.Enabled = false;
                    cbx_difficulty.Enabled = false;
                    lbl_fScore.Text = "Final score: " + (score * 10 * multiplier).ToString();
                    lbl_fScore.Visible = true;
                    lost = false;
                    t.Stop();
                    pbx_alert.Visible = false;
                    progressBar1.Visible = false;
                    MessageBox.Show("You've lost. Try again to get a better score!");
                }

                if (empty == 0 && prepare == false)
                {
                    int randomTrapInt = randomTrap.Next(1, 8);

                    if (randomTrapInt == 1)
                    {
                        Fourth[14].BackColor = ColorBarrier;
                        Fourth[15].BackColor = ColorBarrier;
                        empty = 3;
                        danger = true;
                    }

                    else if (randomTrapInt == 2)
                    {
                        Fifth[15].BackColor = ColorBackGround;
                        empty = 3;
                        danger = true;
                    }

                    else if (randomTrapInt == 3)
                    {
                        First[15].BackColor = ColorBarrier;
                        Second[15].BackColor = ColorBarrier;
                        Third[15].BackColor = ColorBarrier;
                        empty = 3;
                        danger = true;
                    }

                    else if (randomTrapInt == 4)
                    {
                        Fourth[14].BackColor = ColorBarrier;
                        Fourth[15].BackColor = ColorBarrier;
                        First[14].BackColor = ColorBarrier;
                        Second[14].BackColor = ColorBarrier;
                        empty = 3;
                        danger = true;
                    }

                    else if (randomTrapInt == 5)
                    {
                        Fifth[14].BackColor = ColorBackGround;
                        First[14].BackColor = ColorWalls;
                        First[15].BackColor = ColorWalls;
                        First[13].BackColor = ColorWalls;
                        Second[14].BackColor = ColorWalls;
                        empty = 3;
                        danger = true;
                    }

                    else if (randomTrapInt == 6)
                    {
                        prepare = true;
                        empty = 7;
                    }

                    else if (randomTrapInt == 7)
                    {
                        Fourth[15].BackColor = ColorBadGuyBody;
                        Third[15].BackColor = ColorBadGuyHead;
                        empty = 3;

                    }

                }

                else if (prepare && empty == 0)
                {
                    First[15].BackColor = ColorBarrier;
                    Second[15].BackColor = ColorBarrier;
                    Third[15].BackColor = ColorBarrier;
                    Fourth[15].BackColor = ColorDoor;
                    empty = 5;
                    smashCount = 0;
                    progressBar1.Value = smashCount;
                    danger = true;
                    prepare = false;
                    pbx_alert.Image = Image.FromFile("Resources/mashGif.gif");
                    pbx_alert.BackColor = Color.Transparent;
                    pbx_alert.Visible = true;
                    progressBar1.Visible = true;
                }

                else
                {
                    int randomTrapInt = randomTrap.Next(1, 3);
                    empty--;

                    First[15].BackColor = ColorWalls;
                    Second[15].BackColor = ColorBackGround;
                    Third[15].BackColor = ColorBackGround;
                    Fourth[15].BackColor = ColorBackGround;
                    Fifth[15].BackColor = ColorWalls;

                }

            });
        }

        public InsaneBlockRunner()
        {
            InitializeComponent();
            this.TopMost = true;
            cbx_difficulty.Items.AddRange(difficulty);
            cbx_difficulty.SelectedIndex = 1;
            cbx_colorScheme.Items.AddRange(colorScheme);
            cbx_colorScheme.SelectedIndex = 0;
            KeyPreview = true;
            pbx_alert.BackColor = Color.Transparent;
            pbx_alert.BringToFront();
            progressBar1.Visible = false;
            lbl_fScore.Visible = false;
            ColorBackGround = Color.LightYellow;
            ColorBadGuyBody = Color.Orange;
            ColorBarrier = Color.Red;
            ColorBadGuyBody = Color.Black;
            ColorBadGuyHead = Color.Orange;
            ColorDoor = Color.Brown;
            ColorWalls = Color.LightBlue;
            ColorPlayer = Color.DarkOrange;

                Random rndMusic = new Random();
                int rndMusicInt = rndMusic.Next(1, 5);
                if (rndMusicInt == 1)
                {
                    menuMusic.URL = "Music/Rolemusic_-_06_-_He_Plays_Me_The_Best_Rhythms.mp3";
                    lbl_music.Text = "Rolemusic - He Plays Me The Best Rhythms";
                }

                else if (rndMusicInt == 2)
                {
                    menuMusic.URL = "Music/Goto80-datagroove.mp3";
                    lbl_music.Text = "Goto80 - Datagroove";
                }

                else if (rndMusicInt == 3)
                {
                    menuMusic.URL = "Music/Goto80-influensa.mp3";
                    lbl_music.Text = "Goto80 - Influensa";
                }

                else
                {
                    menuMusic.URL = "Music/Tom_Woxom_-_06_-_MASCHINE.mp3";
                    lbl_music.Text = "Tom Woxom - MASCHINE";
                }

                menuMusic.controls.play();
                menuMusic.settings.setMode("loop", true);

        }


        private void CreateGame()
        {
            for (int i = 0; i < 16; i++)
            {
                First[i] = new Button();
                First[i].FlatStyle = FlatStyle.Flat;
                First[i].BackColor = ColorBackGround;
                First[i].Size = new Size(50, 50);
                First[i].Location = new Point(i * 49, 49);
                First[i].FlatAppearance.BorderSize = 0;
                this.Controls.Add(First[i]);
                First[i].Enabled = false;

                Second[i] = new Button();
                Second[i].FlatStyle = FlatStyle.Flat;
                Second[i].BackColor = ColorBackGround;
                Second[i].Size = new Size(50, 50);
                Second[i].Location = new Point(i * 49, 2*49);
                Second[i].FlatAppearance.BorderSize = 0;
                this.Controls.Add(Second[i]);
                Second[i].Enabled = false;

                Third[i] = new Button();
                Third[i].FlatStyle = FlatStyle.Flat;
                Third[i].BackColor = ColorBackGround;
                Third[i].Size = new Size(50, 50);
                Third[i].Location = new Point(i * 49, 3 * 49);
                Third[i].FlatAppearance.BorderSize = 0;
                this.Controls.Add(Third[i]);
                Third[i].Enabled = false;

                Fourth[i] = new Button();
                Fourth[i].FlatAppearance.BorderSize = 0;
                Fourth[i].FlatStyle = FlatStyle.Flat;
                Fourth[i].BackColor = ColorBackGround;
                Fourth[i].Size = new Size(50, 50);
                Fourth[i].Location = new Point(i * 49, 4 * 49);
                this.Controls.Add(Fourth[i]);
                Fourth[i].Enabled = false;

                Fifth[i] = new Button();
                Fifth[i].FlatAppearance.BorderSize = 0;
                Fifth[i].FlatStyle = FlatStyle.Flat;
                Fifth[i].BackColor = ColorWalls;
                Fifth[i].Size = new Size(50, 50);
                Fifth[i].Location = new Point(i * 49, 5 * 49);
                this.Controls.Add(Fifth[i]);
                Fifth[i].Enabled = false;
            }

            Fourth[3].BackColor = ColorPlayer;

        }

        private void b_up_Click(object sender, EventArgs e)
        {
            jump = true;
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            if (first) { Application.Restart(); }
            first = true;
            int speed = 150;
            CreateGame();
            if (cbx_difficulty.SelectedIndex == 0) { speed = 180; multiplier = 1; clockMax = 1; }
            else if (cbx_difficulty.SelectedIndex == 1) { speed = 150; multiplier = 2; clockMax = 2; }
            else if (cbx_difficulty.SelectedIndex == 2) { speed = 130; multiplier = 3; clockMax = 3; }
            else if (cbx_difficulty.SelectedIndex == 3) { speed = 100; multiplier = 5; clockMax = 4; }
            t = new System.Timers.Timer(speed);
            t.Elapsed += new System.Timers.ElapsedEventHandler(Interval);
            t.Start();
            lbl_fScore.Visible = false;
            gbx_game.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            smashCount++;
            if (smashCount > 10) smashCount = 10;
            if (smashCount > 4) smash = true;
            else smash = false;
            progressBar1.Value = smashCount;
            if (prepare) speed = speed - 3;

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            if (Fourth[3].BackColor == ColorPlayer || Third[3].BackColor==ColorPlayer)
            {
                for (int i = 3; i < 16; i++)
                {
                    if (Fourth[i].BackColor == ColorBadGuyBody || Third[i].BackColor == ColorBadGuyHead)
                    {
                        Fourth[i].BackColor = ColorBackGround;
                        Third[i].BackColor = ColorBackGround;
                        score++;
                        i = 15;
                    }
                }
            }

        }

        private void InsaneBlockRunner_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W) 
            {
                jump = true;
            }


        }

        private void InsaneBlockRunner_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                if (Fourth[3].BackColor == ColorPlayer || Third[3].BackColor == ColorPlayer)
                {
                    for (int i = 3; i < 16; i++)
                    {
                        if (Fourth[i].BackColor == ColorBadGuyBody || Third[i].BackColor == ColorBadGuyHead)
                        {
                            Fourth[i].BackColor = ColorBackGround;
                            Third[i].BackColor = ColorBackGround;
                            score++;
                            i = 15;
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.A)
            {
                smashCount++;
                if (smashCount > 10) smashCount = 10;
                if (smashCount > 4) { smash = true; }
                else {smash = false;}
                progressBar1.Value = smashCount;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void b_about_Click(object sender, EventArgs e)
        {
        }

        private void cbx_difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_colorScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_colorScheme.SelectedIndex == 0)
            {
                ColorBackGround = Color.LightYellow;
                ColorBarrier = Color.Red;
                ColorBadGuyBody = Color.Black;
                ColorBadGuyHead = Color.Orange;
                ColorDoor = Color.Brown;
                ColorWalls = Color.LightBlue;
                ColorPlayer = Color.DarkOrange;
            }

            else if (cbx_colorScheme.SelectedIndex == 1)
            {
                ColorBackGround = Color.LightCyan;
                ColorBadGuyBody = Color.Black;
                ColorBarrier = Color.Navy;
                ColorBadGuyHead = Color.DodgerBlue;
                ColorDoor = Color.Indigo;
                ColorWalls = Color.LightBlue;
                ColorPlayer = Color.RoyalBlue;
            }

            else if (cbx_colorScheme.SelectedIndex == 2)
            {
                ColorBackGround = Color.Navy;
                ColorBadGuyBody = Color.Black;
                ColorBarrier = Color.DarkViolet;
                ColorBadGuyHead = Color.Sienna;
                ColorDoor = Color.Indigo;
                ColorWalls = Color.DarkMagenta;
                ColorPlayer = Color.Chocolate;
            }

            else if (cbx_colorScheme.SelectedIndex==3)
            {
                ColorBackGround = Color.Moccasin;
                ColorBadGuyBody = Color.Sienna;
                ColorBarrier = Color.Gray;
                ColorBadGuyHead = Color.Peru;
                ColorDoor = Color.LightSteelBlue;
                ColorWalls = Color.DarkOliveGreen;
                ColorPlayer = Color.Chocolate;
            }

            else
            {
                ColorBackGround = Color.Blue;
                ColorBadGuyBody = Color.Green;
                ColorBarrier = Color.Red;
                ColorBadGuyHead = Color.Orange;
                ColorDoor = Color.Purple;
                ColorWalls = Color.Yellow;
                ColorPlayer = Color.DarkOrange;
            }
        }


    }
}
