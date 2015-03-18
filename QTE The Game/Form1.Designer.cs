namespace QTE_The_Game
{
    partial class InsaneBlockRunner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsaneBlockRunner));
            this.b_up = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.cbx_difficulty = new System.Windows.Forms.ComboBox();
            this.lbl_fScore = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_smash = new System.Windows.Forms.Button();
            this.pbx_alert = new System.Windows.Forms.PictureBox();
            this.gbx_game = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_colorScheme = new System.Windows.Forms.ComboBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_music = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_alert)).BeginInit();
            this.gbx_game.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_up
            // 
            this.b_up.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_up.ForeColor = System.Drawing.Color.Black;
            this.b_up.Location = new System.Drawing.Point(6, 32);
            this.b_up.Name = "b_up";
            this.b_up.Size = new System.Drawing.Size(300, 51);
            this.b_up.TabIndex = 0;
            this.b_up.Text = "Jump [W]";
            this.b_up.UseVisualStyleBackColor = true;
            this.b_up.Click += new System.EventHandler(this.b_up_Click);
            // 
            // b_start
            // 
            this.b_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_start.ForeColor = System.Drawing.Color.Black;
            this.b_start.Location = new System.Drawing.Point(216, 124);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(135, 42);
            this.b_start.TabIndex = 1;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_shoot.ForeColor = System.Drawing.Color.Black;
            this.btn_shoot.Location = new System.Drawing.Point(156, 90);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(150, 45);
            this.btn_shoot.TabIndex = 2;
            this.btn_shoot.Text = "Shoot [D]";
            this.btn_shoot.UseVisualStyleBackColor = true;
            this.btn_shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // cbx_difficulty
            // 
            this.cbx_difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_difficulty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_difficulty.FormattingEnabled = true;
            this.cbx_difficulty.Location = new System.Drawing.Point(132, 80);
            this.cbx_difficulty.Name = "cbx_difficulty";
            this.cbx_difficulty.Size = new System.Drawing.Size(219, 29);
            this.cbx_difficulty.TabIndex = 3;
            this.cbx_difficulty.SelectedIndexChanged += new System.EventHandler(this.cbx_difficulty_SelectedIndexChanged);
            // 
            // lbl_fScore
            // 
            this.lbl_fScore.AutoSize = true;
            this.lbl_fScore.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_fScore.Location = new System.Drawing.Point(7, 14);
            this.lbl_fScore.Name = "lbl_fScore";
            this.lbl_fScore.Size = new System.Drawing.Size(119, 25);
            this.lbl_fScore.TabIndex = 5;
            this.lbl_fScore.Text = "Final Score: ";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBar1.Location = new System.Drawing.Point(423, 9);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(104, 30);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btn_smash
            // 
            this.btn_smash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_smash.ForeColor = System.Drawing.Color.Black;
            this.btn_smash.Location = new System.Drawing.Point(6, 89);
            this.btn_smash.Name = "btn_smash";
            this.btn_smash.Size = new System.Drawing.Size(144, 46);
            this.btn_smash.TabIndex = 7;
            this.btn_smash.Text = "Smash [A]";
            this.btn_smash.UseVisualStyleBackColor = true;
            this.btn_smash.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbx_alert
            // 
            this.pbx_alert.BackColor = System.Drawing.Color.Transparent;
            this.pbx_alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_alert.Location = new System.Drawing.Point(258, 1);
            this.pbx_alert.Name = "pbx_alert";
            this.pbx_alert.Size = new System.Drawing.Size(166, 45);
            this.pbx_alert.TabIndex = 9;
            this.pbx_alert.TabStop = false;
            // 
            // gbx_game
            // 
            this.gbx_game.BackColor = System.Drawing.Color.Transparent;
            this.gbx_game.Controls.Add(this.label3);
            this.gbx_game.Controls.Add(this.cbx_colorScheme);
            this.gbx_game.Controls.Add(this.btn_exit);
            this.gbx_game.Controls.Add(this.label1);
            this.gbx_game.Controls.Add(this.cbx_difficulty);
            this.gbx_game.Controls.Add(this.b_start);
            this.gbx_game.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbx_game.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbx_game.Location = new System.Drawing.Point(398, 325);
            this.gbx_game.Name = "gbx_game";
            this.gbx_game.Size = new System.Drawing.Size(374, 179);
            this.gbx_game.TabIndex = 10;
            this.gbx_game.TabStop = false;
            this.gbx_game.Text = "Game Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color Scheme:";
            // 
            // cbx_colorScheme
            // 
            this.cbx_colorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_colorScheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_colorScheme.FormattingEnabled = true;
            this.cbx_colorScheme.Location = new System.Drawing.Point(132, 37);
            this.cbx_colorScheme.Name = "cbx_colorScheme";
            this.cbx_colorScheme.Size = new System.Drawing.Size(219, 29);
            this.cbx_colorScheme.TabIndex = 7;
            this.cbx_colorScheme.SelectedIndexChanged += new System.EventHandler(this.cbx_colorScheme_SelectedIndexChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(25, 124);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(133, 42);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit Game";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difficulty:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_smash);
            this.groupBox1.Controls.Add(this.btn_shoot);
            this.groupBox1.Controls.Add(this.b_up);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons and Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(8, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Music:";
            // 
            // lbl_music
            // 
            this.lbl_music.AutoSize = true;
            this.lbl_music.BackColor = System.Drawing.Color.Transparent;
            this.lbl_music.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_music.ForeColor = System.Drawing.Color.Black;
            this.lbl_music.Location = new System.Drawing.Point(53, 486);
            this.lbl_music.Name = "lbl_music";
            this.lbl_music.Size = new System.Drawing.Size(44, 17);
            this.lbl_music.TabIndex = 7;
            this.lbl_music.Text = "music";
            // 
            // InsaneBlockRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QTE_The_Game.Properties.Resources.BRR;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.Controls.Add(this.lbl_music);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbx_game);
            this.Controls.Add(this.pbx_alert);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_fScore);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsaneBlockRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Block Runner Rampage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InsaneBlockRunner_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InsaneBlockRunner_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_alert)).EndInit();
            this.gbx_game.ResumeLayout(false);
            this.gbx_game.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_up;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.ComboBox cbx_difficulty;
        private System.Windows.Forms.Label lbl_fScore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_smash;
        private System.Windows.Forms.PictureBox pbx_alert;
        private System.Windows.Forms.GroupBox gbx_game;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_colorScheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_music;

    }
}

