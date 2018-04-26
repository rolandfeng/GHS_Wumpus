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

        public void updateScore() //should we do it in real time or at the end. If at end, just make this method return score
        {
            score = 100 - turn + coinCount + (10 * arrowCount);
        }
    }
}
