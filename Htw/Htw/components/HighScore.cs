using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    public class HighScore
    {
        private int highScore;
        private String playerName;
        private String date;

        public HighScore(int highScore, String playerName, String date)
        {
            this.playerName = playerName;
            this.highScore = highScore;
            this.date = date;
        }

        public int getHighScore()
        {
            return highScore;
        }

        public String getPlayerName()
        {
            return playerName;
        }

        public String getDate()
        {
            return date;
        }
    }
}
