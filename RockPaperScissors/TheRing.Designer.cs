namespace RockPaperScissors
{
    partial class TheRing
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
            this.title = new System.Windows.Forms.Label();
            this.vs = new System.Windows.Forms.Label();
            this.grpRing = new System.Windows.Forms.GroupBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.btnLizard = new System.Windows.Forms.Button();
            this.btnSpock = new System.Windows.Forms.Button();
            this.TiesCount = new System.Windows.Forms.Label();
            this.ComputerCount = new System.Windows.Forms.Label();
            this.PlayerCount = new System.Windows.Forms.Label();
            this.Ties = new System.Windows.Forms.Label();
            this.ComputerWins = new System.Windows.Forms.Label();
            this.PlayerWins = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnScisscors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.scoreBoard = new System.Windows.Forms.GroupBox();
            this.grpRing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.scoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(204, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Monster-Bash";
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.vs.ForeColor = System.Drawing.Color.Gold;
            this.vs.Location = new System.Drawing.Point(284, 201);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(30, 24);
            this.vs.TabIndex = 3;
            this.vs.Text = "vs";
            // 
            // grpRing
            // 
            this.grpRing.BackColor = System.Drawing.Color.Maroon;
            this.grpRing.Controls.Add(this.scoreBoard);
            this.grpRing.Controls.Add(this.picComputer);
            this.grpRing.Controls.Add(this.picPlayer);
            this.grpRing.Controls.Add(this.btnLizard);
            this.grpRing.Controls.Add(this.btnSpock);
            this.grpRing.Controls.Add(this.btnQuit);
            this.grpRing.Controls.Add(this.btnScisscors);
            this.grpRing.Controls.Add(this.btnPaper);
            this.grpRing.Controls.Add(this.btnRock);
            this.grpRing.Controls.Add(this.vs);
            this.grpRing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpRing.ForeColor = System.Drawing.Color.Gold;
            this.grpRing.Location = new System.Drawing.Point(21, 62);
            this.grpRing.Name = "grpRing";
            this.grpRing.Size = new System.Drawing.Size(605, 562);
            this.grpRing.TabIndex = 5;
            this.grpRing.TabStop = false;
            this.grpRing.Text = "The Ring";
            // 
            // picComputer
            // 
            this.picComputer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picComputer.Image = global::RockPaperScissors.Properties.Resources.spock;
            this.picComputer.Location = new System.Drawing.Point(319, 33);
            this.picComputer.Margin = new System.Windows.Forms.Padding(1);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(267, 342);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputer.TabIndex = 18;
            this.picComputer.TabStop = false;
            this.picComputer.Visible = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.Image = global::RockPaperScissors.Properties.Resources.spock;
            this.picPlayer.Location = new System.Drawing.Point(9, 33);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(1);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(267, 342);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 17;
            this.picPlayer.TabStop = false;
            this.picPlayer.Visible = false;
            // 
            // btnLizard
            // 
            this.btnLizard.BackColor = System.Drawing.Color.Black;
            this.btnLizard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLizard.Location = new System.Drawing.Point(164, 442);
            this.btnLizard.Name = "btnLizard";
            this.btnLizard.Size = new System.Drawing.Size(142, 48);
            this.btnLizard.TabIndex = 16;
            this.btnLizard.Text = "Spiked Jaw Dragon (Lizard)";
            this.btnLizard.UseVisualStyleBackColor = false;
            this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
            // 
            // btnSpock
            // 
            this.btnSpock.BackColor = System.Drawing.Color.Black;
            this.btnSpock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSpock.Location = new System.Drawing.Point(16, 500);
            this.btnSpock.Name = "btnSpock";
            this.btnSpock.Size = new System.Drawing.Size(142, 48);
            this.btnSpock.TabIndex = 15;
            this.btnSpock.Text = "Mind Lord (Spock)";
            this.btnSpock.UseVisualStyleBackColor = false;
            this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
            // 
            // TiesCount
            // 
            this.TiesCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TiesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TiesCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TiesCount.Location = new System.Drawing.Point(152, 125);
            this.TiesCount.Name = "TiesCount";
            this.TiesCount.Size = new System.Drawing.Size(76, 22);
            this.TiesCount.TabIndex = 14;
            this.TiesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputerCount
            // 
            this.ComputerCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComputerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ComputerCount.Location = new System.Drawing.Point(152, 80);
            this.ComputerCount.Name = "ComputerCount";
            this.ComputerCount.Size = new System.Drawing.Size(76, 22);
            this.ComputerCount.TabIndex = 13;
            this.ComputerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerCount
            // 
            this.PlayerCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayerCount.Location = new System.Drawing.Point(152, 41);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(76, 22);
            this.PlayerCount.TabIndex = 12;
            this.PlayerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ties
            // 
            this.Ties.AutoSize = true;
            this.Ties.Location = new System.Drawing.Point(82, 125);
            this.Ties.Name = "Ties";
            this.Ties.Size = new System.Drawing.Size(55, 18);
            this.Ties.TabIndex = 11;
            this.Ties.Text = "Ties : ";
            // 
            // ComputerWins
            // 
            this.ComputerWins.AutoSize = true;
            this.ComputerWins.Location = new System.Drawing.Point(6, 82);
            this.ComputerWins.Name = "ComputerWins";
            this.ComputerWins.Size = new System.Drawing.Size(140, 18);
            this.ComputerWins.TabIndex = 10;
            this.ComputerWins.Text = "Computer Wins : ";
            // 
            // PlayerWins
            // 
            this.PlayerWins.AutoSize = true;
            this.PlayerWins.Location = new System.Drawing.Point(24, 41);
            this.PlayerWins.Name = "PlayerWins";
            this.PlayerWins.Size = new System.Drawing.Size(113, 18);
            this.PlayerWins.TabIndex = 9;
            this.PlayerWins.Text = "Player Wins : ";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Black;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnQuit.Location = new System.Drawing.Point(162, 500);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(142, 48);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnScisscors
            // 
            this.btnScisscors.BackColor = System.Drawing.Color.Black;
            this.btnScisscors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnScisscors.Location = new System.Drawing.Point(16, 442);
            this.btnScisscors.Name = "btnScisscors";
            this.btnScisscors.Size = new System.Drawing.Size(142, 48);
            this.btnScisscors.TabIndex = 6;
            this.btnScisscors.Text = "Space Knight (Scissors)";
            this.btnScisscors.UseVisualStyleBackColor = false;
            this.btnScisscors.Click += new System.EventHandler(this.btnScisscors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Black;
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPaper.Location = new System.Drawing.Point(164, 388);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(142, 48);
            this.btnPaper.TabIndex = 5;
            this.btnPaper.Text = "Venus Fly Beast (Paper)";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Black;
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRock.Location = new System.Drawing.Point(16, 388);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(142, 48);
            this.btnRock.TabIndex = 4;
            this.btnRock.Text = "Golem (Rock)";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // scoreBoard
            // 
            this.scoreBoard.BackColor = System.Drawing.Color.Black;
            this.scoreBoard.Controls.Add(this.PlayerWins);
            this.scoreBoard.Controls.Add(this.ComputerWins);
            this.scoreBoard.Controls.Add(this.Ties);
            this.scoreBoard.Controls.Add(this.PlayerCount);
            this.scoreBoard.Controls.Add(this.ComputerCount);
            this.scoreBoard.Controls.Add(this.TiesCount);
            this.scoreBoard.ForeColor = System.Drawing.Color.Gold;
            this.scoreBoard.Location = new System.Drawing.Point(310, 388);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(257, 160);
            this.scoreBoard.TabIndex = 19;
            this.scoreBoard.TabStop = false;
            this.scoreBoard.Text = "Score";
            // 
            // TheRing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(644, 642);
            this.Controls.Add(this.grpRing);
            this.Controls.Add(this.title);
            this.MinimumSize = new System.Drawing.Size(660, 680);
            this.Name = "TheRing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monster-Bash";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.grpRing.ResumeLayout(false);
            this.grpRing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.scoreBoard.ResumeLayout(false);
            this.scoreBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.GroupBox grpRing;
        private System.Windows.Forms.Label PlayerCount;
        private System.Windows.Forms.Label Ties;
        private System.Windows.Forms.Label ComputerWins;
        private System.Windows.Forms.Label PlayerWins;
        private System.Windows.Forms.Label TiesCount;
        private System.Windows.Forms.Label ComputerCount;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnScisscors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnLizard;
        private System.Windows.Forms.Button btnSpock;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.GroupBox scoreBoard;
    }
}

