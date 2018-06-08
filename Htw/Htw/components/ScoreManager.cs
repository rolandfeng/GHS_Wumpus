using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.forms;

namespace wumpus.components
{
    public class ScoreManager
    {
        private List<HighScore> highScoresList;
        private const int MAX_NUMBER_OF_HIGH_SCORES = 10;

        public ScoreManager()
        {
        }

        public void LoadHighScores()
        {
            string[] lines = File.ReadAllLines(@"..\..\Resource\HighScores.txt");
            highScoresList = new List<HighScore>();
            foreach (string line in lines) {                 
                string[] segments = line.Split(';');
                int highScore = Int32.Parse(segments[0]);
                string playerName = segments[1];
                string date = segments[2];
                HighScore temp = new HighScore(highScore, playerName, date);
                highScoresList.Add(temp);
            }
        }

        public Boolean testScore(int newScore)
        {
            return newScore > highScoresList[9].getHighScore();    
        }

        public void StoreHighScore(string username, int highScore)
        {
            LoadHighScores();
            DateTime dateTime = DateTime.UtcNow.Date;
            string date = dateTime.ToString("MM/dd/yyyy");
            HighScore newScore = new HighScore(highScore, username, date);
            highScoresList.Add(newScore);
            highScoresList.Sort();
            trimHighScores();
            WriteHighScoresToFile(@"..\..\Resource\HighScores.txt", highScoresList);
        }

        private void trimHighScores()
        {
            if (highScoresList.Count > MAX_NUMBER_OF_HIGH_SCORES)
                while(highScoresList.Count > MAX_NUMBER_OF_HIGH_SCORES)
                {
                    highScoresList.RemoveAt(highScoresList.Count - 1);
                }
        }

        private void WriteHighScoresToFile(String filename, List<HighScore> highScoresList)
        {
            List<string> data = new List<string>();
            foreach (HighScore highScore in highScoresList)
            {
                string line = highScore.getHighScore() + ";" + highScore.getPlayerName() + ";" + highScore.getDate();
                data.Add(line);
            }
            string[] dataArray = data.ToArray();
            File.WriteAllLines(filename, dataArray);
        }
    
        public void DisplayHighScores()
        {
            HighScoresForm highScoresForm = new HighScoresForm();
            highScoresForm.setHighScoresList(this.highScoresList);
            highScoresForm.update();
            highScoresForm.Show();
        }
    }
}