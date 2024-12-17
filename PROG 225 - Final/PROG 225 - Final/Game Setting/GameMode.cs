using PROG_225___Final.Snake_Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_225___Final.Game_Setting
{
    public partial class GameMode : Form
    {

        public GameMode()
        {
            InitializeComponent();
        }

        private void GameMode_Load(object sender, EventArgs e)
        {
            tbtnGameMode.Location = new Point((ClientSize.Width - tbtnGameMode.Width) / 2, (ClientSize.Height - tbtnGameMode.Height) / 2);

            rbtnStart.Location = new Point((ClientSize.Width - rbtnStart.Width) / 2, ClientSize.Height - rbtnStart.Height - 70);
            rbtnReturn.Location = new Point((ClientSize.Width - rbtnStart.Width) / 2, ClientSize.Height - rbtnReturn.Height - 10);

            lbEndless.BorderStyle = BorderStyle.FixedSingle;
            lbEndless.BackColor = Color.PaleVioletRed;
        }

        private void rbtnStart_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();

            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrWhiteSpace(tbUsername.Text))
                tbUsername.Text = "Anon";

            game.name = tbUsername.Text;
            game.Show();
            Close();
        }

        private void tbtnGameMode_CheckedChanged(object sender, EventArgs e)
        {
            if (tbtnGameMode.Checked)
            {
                Snake.gameModeType = true;
                lbEndless.BorderStyle = BorderStyle.None;
                lbEndless.BackColor = Form.DefaultBackColor;
                lbWall.BorderStyle = BorderStyle.FixedSingle;
                lbWall.BackColor = Color.LightGreen;
            }
            else
            {
                Snake.gameModeType = false;
                lbEndless.BorderStyle = BorderStyle.FixedSingle;
                lbEndless.BackColor = Color.PaleVioletRed;
                lbWall.BackColor = Form.DefaultBackColor;
                lbWall.BorderStyle = BorderStyle.None;
            }
        }

        private void rbtnReturn_Click(object sender, EventArgs e)
        {
            Option.menuForm.Show();
            Close();
        }
    }
}
