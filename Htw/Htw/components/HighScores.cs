using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    class HighScores
    {
        private int highScore;
        private String playerName;

        public HighScores(int highScore, String playerName)
        {
            this.playerName = playerName;
            this.highScore = highScore;
        }

        public void StoreHighScore(int highScore) 
        {
            // load resource file, insert the high score into file, save file 
        }

        public void DisplayHighScores()
        {
            
        }
    }
}
