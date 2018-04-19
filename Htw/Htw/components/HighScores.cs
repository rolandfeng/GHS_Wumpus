using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wumpus.components
{
    class HighScores
    {
        private int highScore;
        private String playerName;
        private DateTime date;
        private List<HighScores> HighScoresList = new List<HighScores>();

        public HighScores(int highScore, String playerName, DateTime date)
        {
            this.playerName = playerName;
            this.highScore = highScore;
            this.date = date;
        }

        public void StoreHighScore(int highScore, String playerName, DateTime date)
        {
            string playerInfo = highScore + "; " + playerName + "; " + date.ToShortDateString();
            System.IO.File.AppendAllText(@"H:\APCS\WumpusWhite\Htw\Htw\Resource\HighScores.txt", playerInfo);
            string[] lines = File.ReadAllLines(@"H:\APCS\WumpusWhite\Htw\Htw\Resource\HighScores.txt");
            foreach (string line in lines){
                HighScores temp = new HighScores(highScore playerName, date);

                string[] segments = line.Split(';');
            }
            // load resource file, insert the high score into file, save file 
        }

        public void DisplayHighScores()
        {
            
        }
    }
}
