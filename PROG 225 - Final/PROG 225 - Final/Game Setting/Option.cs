using PROG_225___Final.Snake_Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_225___Final.Game_Setting
{
    public partial class Option : Form
    {
        public static Form menuForm;
        public static int bgmLevel;
        public static int sfxLevel;

        public Option()
        {
            InitializeComponent();

            tbMusic.L_Value = bgmLevel = 30;
            lbMusic.Text = tbMusic.L_Value.ToString();

            tbSFX.L_Value = sfxLevel = 100;
            lbSFX.Text = tbSFX.L_Value.ToString();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            Location = new Point(menuForm.Location.X, menuForm.Location.Y);
            btnBack.Location = new Point((ClientSize.Width - btnBack.Width) / 2, (ClientSize.Height / 2) + 40);
        }

        private void lTrackBar1_LValueChanged(object sender, DemoControls.LEventArgs e)
        {
            MainMenu.bgm.settings.volume = tbMusic.L_Value;
            MainMenu.bgm.controls.play();
            lbMusic.Text = $"{tbMusic.L_Value}";
        }

        private void tbSFX_LValueChanged(object sender, DemoControls.LEventArgs e)
        {
            Snake.soundFX.settings.volume = tbSFX.L_Value;
            lbSFX.Text = $"{tbSFX.L_Value}";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
