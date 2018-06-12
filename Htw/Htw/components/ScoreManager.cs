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

        //Loads high scores from text file into ArrayList
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

        //Tests whether the new score is in the top 10 of the highscoreslist
        public Boolean testScore(int newScore)
        {
            return newScore > highScoresList[9].getHighScore();    
        }
        
        //stores inputted highscore as well as name and date into HighScores text file
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

        //Trims the highscores text file if there are more than 10 scores
        private void trimHighScores()
        {
            if (highScoresList.Count > MAX_NUMBER_OF_HIGH_SCORES)
                while(highScoresList.Count > MAX_NUMBER_OF_HIGH_SCORES)
                {
                    highScoresList.RemoveAt(highScoresList.Count - 1);
                }
        }

        //Transfers the highscores from the ArrayList and saves them into the text file
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
    
        //Displays HighScores form and updates
        public void DisplayHighScores()
        {
            HighScoresForm highScoresForm = new HighScoresForm();
            highScoresForm.setHighScoresList(this.highScoresList);
            highScoresForm.update();
            highScoresForm.Show();
        }
    }
}