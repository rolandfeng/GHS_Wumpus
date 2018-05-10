using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wumpus.components
{
    class ScoreManager : IComparable<ScoreManager>
    {
        private List<HighScore> HighScoresList;

        public ScoreManager()
        {
        }
        public void LoadHighScores()
        {
            //string[] lines = File.ReadAllLines(@"..\..\Resource\HighScores.txt");
            //HighScoresList = new List<ScoreManager>();
            //foreach (string line in lines) {                 
            //    string[] segments = line.Split(';');
            //    highScore = Int32.Parse(segments[0]);
            //    playerName = segments[1];
            //    date = segments[2];
            //    ScoreManager temp = new ScoreManager(highScore, playerName, date);
            //    HighScoresList.Add(temp);
            // }

        }

        private void SortList()
        {
            //HighScoresList.Sort((ScoreManager first, ScoreManager second) =>
            //{
            //    if (first.highScore < second.highScore)
            //    {
            //        return -1;
            //    }
            //    else if (first.highScore > second.highScore)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //});
        }

        public void StoreHighScore(int highScore, String playerName, String date)
        {
            string playerInfo = highScore + "; " + playerName + "; " + date;
            System.IO.File.AppendAllText(@"H:\APCS\WumpusWhite\Htw\Htw\Resource\HighScores.txt", playerInfo);
           
            // load resource file, insert the high score into file, save file 
        }

        private void WriteHighScoresToFile()
        {

        }
    
        public void DisplayHighScores()
        {
        }
    }
}