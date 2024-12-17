namespace PROG_225___Final.Game_Setting
{
    partial class Ranks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranks));
            lsbRanks = new ListBox();
            rbtnReturn = new Custom_Controls.RoundedButtons();
            SuspendLayout();
            // 
            // lsbRanks
            // 
            lsbRanks.BackColor = Color.FromArgb(255, 224, 192);
            lsbRanks.Font = new Font("UD Digi Kyokasho N-R", 24F, FontStyle.Underline, GraphicsUnit.Point, 128);
            lsbRanks.FormattingEnabled = true;
            lsbRanks.ItemHeight = 37;
            lsbRanks.Location = new Point(32, 38);
            lsbRanks.Name = "lsbRanks";
            lsbRanks.SelectionMode = SelectionMode.None;
            lsbRanks.Size = new Size(256, 485);
            lsbRanks.TabIndex = 0;
            // 
            // rbtnReturn
            // 
            rbtnReturn.BackColor = Color.MediumSpringGreen;
            rbtnReturn.BackgroundColor = Color.MediumSpringGreen;
            rbtnReturn.BorderColor = Color.PaleVioletRed;
            rbtnReturn.BorderRadius = 20;
            rbtnReturn.BorderSize = 0;
            rbtnReturn.FlatAppearance.BorderSize = 0;
            rbtnReturn.FlatStyle = FlatStyle.Flat;
            rbtnReturn.Font = new Font("UD Digi Kyokasho N-R", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbtnReturn.ForeColor = Color.Black;
            rbtnReturn.Location = new Point(79, 560);
            rbtnReturn.Name = "rbtnReturn";
            rbtnReturn.Size = new Size(150, 40);
            rbtnReturn.TabIndex = 1;
            rbtnReturn.Text = "RETURN";
            rbtnReturn.TextColor = Color.Black;
            rbtnReturn.UseVisualStyleBackColor = false;
            rbtnReturn.Click += rbtnReturn_Click;
            // 
            // Ranks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(314, 649);
            Controls.Add(rbtnReturn);
            Controls.Add(lsbRanks);
            ForeColor = Color.FromArgb(0, 64, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ranks";
            StartPosition = FormStartPosition.Manual;
            Text = "Ranks";
            Load += Ranks_Load;
            ResumeLayout(false);
        }

        #endregion
        private Custom_Controls.RoundedButtons rbtnReturn;
        public ListBox lsbRanks;
    }
}