using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wumpus.components
{
    class HighScores : IComparable<HighScores>
    {
        private int highScore;
        private String playerName;
        private String date;
        private List<HighScores> HighScoresList;

        public HighScores(int highScore, String playerName, String date)
        {
            this.playerName = playerName;
            this.highScore = highScore;
            this.date = date;
        }

        public void StoreHighScore(int highScore, String playerName, String date)
        {
            string playerInfo = highScore + "; " + playerName + "; " + date;
            System.IO.File.AppendAllText(@"H:\APCS\WumpusWhite\Htw\Htw\Resource\HighScores.txt", playerInfo);
            string[] lines = File.ReadAllLines(@"H:\APCS\WumpusWhite\Htw\Htw\Resource\HighScores.txt");
            foreach (string line in lines)
            HighScoresList = new List<HighScores>();
            {
                string[] segments = line.Split(';');
                highScore = Int32.Parse(segments[0]);
                playerName = segments[1];
                date = segments[2];
                HighScores temp = new HighScores(highScore, playerName, date);
                HighScoresList.Add(temp);
                
            }
            // load resource file, insert the high score into file, save file 
        }
        public void DisplayHighScores()
        {
        }
        public int CompareTo(HighScores other)
        {
            return (this.highScore.CompareTo(other.highScore));
        }
    }
}