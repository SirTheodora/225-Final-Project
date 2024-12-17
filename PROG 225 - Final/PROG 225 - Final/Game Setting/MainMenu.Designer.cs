namespace PROG_225___Final.Game_Setting
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            btnPlay = new Custom_Controls.RoundedButtons();
            btnOption = new Custom_Controls.RoundedButtons();
            btnExit = new Custom_Controls.RoundedButtons();
            rbtnRanks = new Custom_Controls.RoundedButtons();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.YellowGreen;
            btnPlay.BackgroundColor = Color.YellowGreen;
            btnPlay.BorderColor = Color.Green;
            btnPlay.BorderRadius = 20;
            btnPlay.BorderSize = 0;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("UD Digi Kyokasho NP-R", 18F, FontStyle.Italic, GraphicsUnit.Point, 128);
            btnPlay.ForeColor = Color.Black;
            btnPlay.Location = new Point(63, 36);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(176, 79);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "PLAY";
            btnPlay.TextColor = Color.Black;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnOption
            // 
            btnOption.BackColor = Color.YellowGreen;
            btnOption.BackgroundColor = Color.YellowGreen;
            btnOption.BorderColor = Color.Green;
            btnOption.BorderRadius = 20;
            btnOption.BorderSize = 0;
            btnOption.FlatAppearance.BorderSize = 0;
            btnOption.FlatStyle = FlatStyle.Flat;
            btnOption.Font = new Font("UD Digi Kyokasho NP-R", 18F, FontStyle.Italic, GraphicsUnit.Point, 128);
            btnOption.ForeColor = Color.Black;
            btnOption.Location = new Point(63, 316);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(176, 79);
            btnOption.TabIndex = 2;
            btnOption.Text = "OPTIONS";
            btnOption.TextColor = Color.Black;
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.YellowGreen;
            btnExit.BackgroundColor = Color.YellowGreen;
            btnExit.BorderColor = Color.Green;
            btnExit.BorderRadius = 20;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("UD Digi Kyokasho NP-R", 18F, FontStyle.Italic, GraphicsUnit.Point, 128);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(63, 459);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 79);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.TextColor = Color.Black;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // rbtnRanks
            // 
            rbtnRanks.BackColor = Color.YellowGreen;
            rbtnRanks.BackgroundColor = Color.YellowGreen;
            rbtnRanks.BorderColor = Color.Green;
            rbtnRanks.BorderRadius = 20;
            rbtnRanks.BorderSize = 0;
            rbtnRanks.FlatAppearance.BorderSize = 0;
            rbtnRanks.FlatStyle = FlatStyle.Flat;
            rbtnRanks.Font = new Font("UD Digi Kyokasho NP-R", 18F, FontStyle.Italic, GraphicsUnit.Point, 128);
            rbtnRanks.ForeColor = Color.Black;
            rbtnRanks.Location = new Point(63, 178);
            rbtnRanks.Name = "rbtnRanks";
            rbtnRanks.Size = new Size(176, 79);
            rbtnRanks.TabIndex = 4;
            rbtnRanks.Text = "RANKING";
            rbtnRanks.TextColor = Color.Black;
            rbtnRanks.UseVisualStyleBackColor = false;
            rbtnRanks.Click += rbtnRanks_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 649);
            Controls.Add(rbtnRanks);
            Controls.Add(btnExit);
            Controls.Add(btnOption);
            Controls.Add(btnPlay);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.RoundedButtons btnPlay;
        private Custom_Controls.RoundedButtons btnOption;
        private Custom_Controls.RoundedButtons btnExit;
        private Custom_Controls.RoundedButtons rbtnRanks;
    }
}