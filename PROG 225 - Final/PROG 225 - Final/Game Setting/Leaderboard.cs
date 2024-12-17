using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PROG_225___Final.Game_Setting
{
    public class Leaderboard
    {
        public static Ranks ranks = new Ranks();
        private const string path = "leaderboard.json";
        public List<ScoreEntry> leaderboard = new List<ScoreEntry>();

        public Leaderboard()
        {
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                leaderboard = JsonSerializer.Deserialize<List<ScoreEntry>>(json) ?? new List<ScoreEntry>();
            }
        }

        private void SaveLeaderboard()
        {
            string json = JsonSerializer.Serialize(leaderboard);
            File.WriteAllText(path, json);
        }

        public void UpdateLeaderboard(ListBox lsb)
        {
            lsb.Items.Clear();
            foreach(var entry in leaderboard.GetRange(0, Math.Min(5, leaderboard.Count)))
            {
                if (entry.Score < 10)
                    lsb.Items.Add($"{entry.Username}          {entry.Score}");
                else if (entry.Score < 100)
                    lsb.Items.Add($"{entry.Username}         {entry.Score}");
                else
                    lsb.Items.Add($"{entry.Username}        {entry.Score}");
            }
        }

        public void AddScore(string username, int score)
        {
            leaderboard.Add(new ScoreEntry { Username = username, Score = score });
            leaderboard.Sort((a, b) => b.Score.CompareTo(a.Score)); // descending sort
            SaveLeaderboard();
        }

        public int ShowHighest()
        {
            int highestScore = leaderboard.Count > 0 ? leaderboard[0].Score : 0;
            return highestScore;
        }
    }
}
