namespace PROG_225___Final.Game_Setting
{
    partial class GameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMode));
            tbtnGameMode = new Custom_Controls.CustomToggleButtons();
            rbtnStart = new Custom_Controls.RoundedButtons();
            lbEndless = new Label();
            lbWall = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tbUsername = new TextBox();
            label1 = new Label();
            rbtnReturn = new Custom_Controls.RoundedButtons();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbtnGameMode
            // 
            tbtnGameMode.AutoSize = true;
            tbtnGameMode.Location = new Point(349, 202);
            tbtnGameMode.MinimumSize = new Size(100, 40);
            tbtnGameMode.Name = "tbtnGameMode";
            tbtnGameMode.OffBackColor = Color.Red;
            tbtnGameMode.OffToggleColor = Color.Gainsboro;
            tbtnGameMode.OnBackColor = Color.Lime;
            tbtnGameMode.OnToggleColor = Color.Gainsboro;
            tbtnGameMode.Size = new Size(100, 40);
            tbtnGameMode.TabIndex = 0;
            tbtnGameMode.UseVisualStyleBackColor = true;
            tbtnGameMode.CheckedChanged += tbtnGameMode_CheckedChanged;
            // 
            // rbtnStart
            // 
            rbtnStart.AutoSize = true;
            rbtnStart.BackColor = Color.LightGreen;
            rbtnStart.BackgroundColor = Color.LightGreen;
            rbtnStart.BorderColor = Color.PaleVioletRed;
            rbtnStart.BorderRadius = 20;
            rbtnStart.BorderSize = 0;
            rbtnStart.FlatAppearance.BorderSize = 0;
            rbtnStart.FlatStyle = FlatStyle.Flat;
            rbtnStart.Font = new Font("UD Digi Kyokasho NP-R", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbtnStart.ForeColor = Color.Black;
            rbtnStart.Location = new Point(310, 315);
            rbtnStart.Name = "rbtnStart";
            rbtnStart.Size = new Size(175, 57);
            rbtnStart.TabIndex = 1;
            rbtnStart.Text = "Start Game";
            rbtnStart.TextColor = Color.Black;
            rbtnStart.UseVisualStyleBackColor = false;
            rbtnStart.Click += rbtnStart_Click;
            // 
            // lbEndless
            // 
            lbEndless.Font = new Font("UD Digi Kyokasho N-R", 24F);
            lbEndless.Location = new Point(43, 129);
            lbEndless.Name = "lbEndless";
            lbEndless.Size = new Size(217, 90);
            lbEndless.TabIndex = 2;
            lbEndless.Text = "Endless Mode";
            lbEndless.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbWall
            // 
            lbWall.Font = new Font("UD Digi Kyokasho N-R", 24F);
            lbWall.Location = new Point(572, 129);
            lbWall.Name = "lbWall";
            lbWall.Size = new Size(197, 90);
            lbWall.TabIndex = 3;
            lbWall.Text = "Wall Mode";
            lbWall.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 451);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(491, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 451);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.InactiveCaption;
            tbUsername.Location = new Point(349, 86);
            tbUsername.MaxLength = 4;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(100, 23);
            tbUsername.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(349, 60);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 7;
            label1.Text = "Enter Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbtnReturn
            // 
            rbtnReturn.AutoSize = true;
            rbtnReturn.BackColor = Color.LightGreen;
            rbtnReturn.BackgroundColor = Color.LightGreen;
            rbtnReturn.BorderColor = Color.PaleVioletRed;
            rbtnReturn.BorderRadius = 20;
            rbtnReturn.BorderSize = 0;
            rbtnReturn.FlatAppearance.BorderSize = 0;
            rbtnReturn.FlatStyle = FlatStyle.Flat;
            rbtnReturn.Font = new Font("UD Digi Kyokasho NP-R", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbtnReturn.ForeColor = Color.Black;
            rbtnReturn.Location = new Point(310, 378);
            rbtnReturn.Name = "rbtnReturn";
            rbtnReturn.Size = new Size(175, 57);
            rbtnReturn.TabIndex = 8;
            rbtnReturn.Text = "Return";
            rbtnReturn.TextColor = Color.Black;
            rbtnReturn.UseVisualStyleBackColor = false;
            rbtnReturn.Click += rbtnReturn_Click;
            // 
            // GameMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtnReturn);
            Controls.Add(label1);
            Controls.Add(tbUsername);
            Controls.Add(lbWall);
            Controls.Add(lbEndless);
            Controls.Add(rbtnStart);
            Controls.Add(tbtnGameMode);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameMode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameMode";
            Load += GameMode_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.CustomToggleButtons tbtnGameMode;
        private Custom_Controls.RoundedButtons rbtnStart;
        private Label lbEndless;
        private Label lbWall;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tbUsername;
        private Label label1;
        private Custom_Controls.RoundedButtons rbtnReturn;
    }
}