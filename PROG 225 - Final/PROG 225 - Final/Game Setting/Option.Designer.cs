namespace PROG_225___Final.Game_Setting
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            btnBack = new Custom_Controls.RoundedButtons();
            tbMusic = new DemoControls.LTrackBar();
            lbMusic = new Label();
            label1 = new Label();
            label2 = new Label();
            tbSFX = new DemoControls.LTrackBar();
            label_20 = new Label();
            lbSFX = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SpringGreen;
            btnBack.BackgroundColor = Color.SpringGreen;
            btnBack.BorderColor = Color.PaleVioletRed;
            btnBack.BorderRadius = 20;
            btnBack.BorderSize = 0;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.FromArgb(64, 0, 0);
            btnBack.Location = new Point(58, 363);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(171, 64);
            btnBack.TabIndex = 0;
            btnBack.Text = "Return";
            btnBack.TextColor = Color.FromArgb(64, 0, 0);
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tbMusic
            // 
            tbMusic.BackgroundImage = (Image)resources.GetObject("tbMusic.BackgroundImage");
            tbMusic.L_BarColor = Color.FromArgb(128, 255, 128);
            tbMusic.L_BarSize = 20;
            tbMusic.L_IsRound = true;
            tbMusic.L_Maximum = 100;
            tbMusic.L_Minimum = 0;
            tbMusic.L_Orientation = DemoControls.Orientation.Horizontal_LR;
            tbMusic.L_SliderColor = Color.FromArgb(0, 192, 0);
            tbMusic.L_Value = 0;
            tbMusic.Location = new Point(6, 184);
            tbMusic.Name = "tbMusic";
            tbMusic.Size = new Size(250, 20);
            tbMusic.TabIndex = 1;
            tbMusic.Text = "lTrackBar1";
            tbMusic.LValueChanged += lTrackBar1_LValueChanged;
            // 
            // lbMusic
            // 
            lbMusic.AutoSize = true;
            lbMusic.Font = new Font("UD Digi Kyokasho N-R", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbMusic.Image = (Image)resources.GetObject("lbMusic.Image");
            lbMusic.Location = new Point(266, 187);
            lbMusic.Name = "lbMusic";
            lbMusic.Size = new Size(16, 18);
            lbMusic.TabIndex = 2;
            lbMusic.Text = "0";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("UD Digi Kyokasho NP-R", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(58, 21);
            label1.Name = "label1";
            label1.Size = new Size(198, 57);
            label1.TabIndex = 3;
            label1.Text = "OPTIONS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho N-R", 12F, FontStyle.Underline, GraphicsUnit.Point, 128);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(6, 163);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 4;
            label2.Text = "Music";
            // 
            // tbSFX
            // 
            tbSFX.BackgroundImage = (Image)resources.GetObject("tbSFX.BackgroundImage");
            tbSFX.L_BarColor = Color.FromArgb(128, 255, 128);
            tbSFX.L_BarSize = 20;
            tbSFX.L_IsRound = true;
            tbSFX.L_Maximum = 100;
            tbSFX.L_Minimum = 0;
            tbSFX.L_Orientation = DemoControls.Orientation.Horizontal_LR;
            tbSFX.L_SliderColor = Color.FromArgb(0, 192, 0);
            tbSFX.L_Value = 0;
            tbSFX.Location = new Point(6, 272);
            tbSFX.Name = "tbSFX";
            tbSFX.Size = new Size(250, 20);
            tbSFX.TabIndex = 5;
            tbSFX.Text = "lTrackBar1";
            tbSFX.LValueChanged += tbSFX_LValueChanged;
            // 
            // label_20
            // 
            label_20.AutoSize = true;
            label_20.Font = new Font("UD Digi Kyokasho N-R", 12F, FontStyle.Underline, GraphicsUnit.Point, 128);
            label_20.Image = (Image)resources.GetObject("label_20.Image");
            label_20.Location = new Point(6, 251);
            label_20.Name = "label_20";
            label_20.Size = new Size(32, 18);
            label_20.TabIndex = 6;
            label_20.Text = "SFX";
            // 
            // lbSFX
            // 
            lbSFX.AutoSize = true;
            lbSFX.Font = new Font("UD Digi Kyokasho N-R", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbSFX.Image = (Image)resources.GetObject("lbSFX.Image");
            lbSFX.Location = new Point(266, 275);
            lbSFX.Name = "lbSFX";
            lbSFX.Size = new Size(16, 18);
            lbSFX.TabIndex = 7;
            lbSFX.Text = "0";
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(314, 649);
            Controls.Add(lbSFX);
            Controls.Add(label_20);
            Controls.Add(tbSFX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbMusic);
            Controls.Add(tbMusic);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Option";
            StartPosition = FormStartPosition.Manual;
            Text = "Option";
            Load += Option_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.RoundedButtons btnBack;
        private Label lbMusic;
        private Label label1;
        private Label label2;
        public DemoControls.LTrackBar tbMusic;
        public DemoControls.LTrackBar tbSFX;
        private Label label_20;
        private Label lbSFX;
    }
}