using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    public class HighScore: IComparable<HighScore>
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

        //Comparable interface to sort list
        public int CompareTo(HighScore that)
        {
            if (this.highScore > that.highScore)
                return -1;
            else if (this.highScore < that.highScore)
                return 1;
            else return 0;
        }
    }
}
