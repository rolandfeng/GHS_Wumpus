using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    class Player
    {
        private int arrowCount;
        private int coinCount;
        private int turn;
        private int score;

        public Player(int arrows, int coins)
        {
            arrowCount = arrows;
            coinCount = coins;
            turn = 0;
            score = 0;
        }

        public int getArrowCount()
        {
            return arrowCount;
        }

        public int getCoinCount()
        {
            return arrowCount;
        }

        public void changeArrowCount(int change)
        {
            arrowCount += change;
        }

        public void changeCoinCount(int change)
        {
            coinCount += change;
        }

        public int getTurn()
        {
            return turn;
        }

        public void changeTurn(int change)
        {
            turn += change;
        }

        public int getScore()
        {
            return score;
        }

        public void changeScore(int change) //do i change the score myself depending on game conditions or is that roland
        {
            score += change;
        }
    }
}
