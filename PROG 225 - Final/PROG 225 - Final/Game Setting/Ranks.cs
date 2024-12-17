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
    public partial class Ranks : Form
    {
        public static Form menuForm;
        private Leaderboard lead;
        public Ranks()
        {
            InitializeComponent();

            Location = new Point(menuForm.Location.X, menuForm.Location.Y);

        }

        private void rbtnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ranks_Load(object sender, EventArgs e)
        {

            lead = new Leaderboard();
            lead.UpdateLeaderboard(lsbRanks);
        }
    }
}
