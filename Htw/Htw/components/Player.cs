using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    public class Player
    {
        private int arrowCount;
        private int coinCount;
        private int turn;
        private int score;
        //private String name;

        public Player() //put back names in these two constructors
        {
            arrowCount = 3;
            coinCount = 0;
            turn = 0;
            score = 0;
            //this.name = name;
        }
        
        public Player(int arrows, int coins)
        {
            this.arrowCount = arrows;
            this.coinCount = coins;
            turn = 0;
            score = 0;
            //this.name = name;
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
            turn++;
            coinCount++;
            score = 100 - turn + coinCount + (10 * arrowCount);
        }
    }
}
