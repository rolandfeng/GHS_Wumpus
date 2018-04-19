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
            return 0;
        }

        public int getCoinCount()
        {
            return 0;
        }

        public void changeArrowCount()
        {

        }

        public void changeCoinCount()
        {

        }

        public int getTurn()
        {
            return 0;
        }

        public void changeTurn()
        {

        }

        public int getScore()
        {
            return 0;
        }

        public void changeScore()
        {

        }
    }
}
