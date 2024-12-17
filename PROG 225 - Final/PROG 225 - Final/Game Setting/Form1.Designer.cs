namespace PROG_225___Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new Custom_Controls.RoundedButtons();
            btnMainMenu = new Custom_Controls.RoundedButtons();
            lbScore = new Label();
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
            btnPlay.Location = new Point(258, 309);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(176, 79);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play Again";
            btnPlay.TextColor = Color.Black;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.YellowGreen;
            btnMainMenu.BackgroundColor = Color.YellowGreen;
            btnMainMenu.BorderColor = Color.Green;
            btnMainMenu.BorderRadius = 20;
            btnMainMenu.BorderSize = 0;
            btnMainMenu.FlatAppearance.BorderSize = 0;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("UD Digi Kyokasho NP-R", 18F, FontStyle.Italic, GraphicsUnit.Point, 128);
            btnMainMenu.ForeColor = Color.Black;
            btnMainMenu.Location = new Point(503, 309);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(176, 79);
            btnMainMenu.TabIndex = 3;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.TextColor = Color.Black;
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.BackColor = Color.Transparent;
            lbScore.Font = new Font("UD Digi Kyokasho N-R", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbScore.Location = new Point(3, 3);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(109, 24);
            lbScore.TabIndex = 4;
            lbScore.Text = "Score : 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 960);
            Controls.Add(btnMainMenu);
            Controls.Add(btnPlay);
            Controls.Add(lbScore);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Custom_Controls.RoundedButtons btnPlay;
        public Custom_Controls.RoundedButtons btnMainMenu;
        public Label lbScore;
        private Label label1;
    }
}
