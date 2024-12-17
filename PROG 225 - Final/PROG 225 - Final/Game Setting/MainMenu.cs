using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PROG_225___Final.Game_Setting
{
    public partial class MainMenu : Form
    {
        public static WindowsMediaPlayer bgm = new WindowsMediaPlayer();
        private int currentIndex = 0;
        private string[] musicFiles;
        private Option opt = new Option();
        public MainMenu()
        {
            InitializeComponent();
            Option.menuForm = this;
            Ranks.menuForm = this;
            bgm.PlayStateChange += BGM_StateChange;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string path = "BGM/";
            musicFiles = Directory.GetFiles(path, ".").Where(file => file.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase) || file.EndsWith(".wav", StringComparison.OrdinalIgnoreCase)).ToArray();
            if (musicFiles.Length == 0)
                return;

            PlayBGM();
        }

        private void BGM_StateChange(int newState)
        {
            if ((WMPPlayState)newState == WMPPlayState.wmppsStopped)
            {
                currentIndex++;
                if (currentIndex >= musicFiles.Length)
                {
                    currentIndex = 0;
                }
                PlayBGM();
            }
        }

        private void PlayBGM()
        {
            if (musicFiles == null || musicFiles.Length == 0)
                return;

            string currentFile = musicFiles[currentIndex];
            bgm.URL = currentFile;
            bgm.settings.volume = opt.tbMusic.L_Value;
            bgm.controls.play();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameMode gm = new GameMode();
            gm.Show();
            Hide();
        }

        private void rbtnRanks_Click(object sender, EventArgs e)
        {
            Ranks rank = new Ranks();
            rank.Show();    
        }
    }
}
