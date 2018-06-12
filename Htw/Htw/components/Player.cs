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

        public Player() //put back names in these two constructors
        {
            arrowCount = 3;
            coinCount = 2;
            turn = 0;

        }
        
        public Player(int arrows, int coins)
        {
            this.arrowCount = arrows;
            this.coinCount = coins;
            turn = 0;

        }

        //return lasers
        public int getArrowCount()
        {
            return arrowCount;
        }

        //return energy charges
        public int getCoinCount()
        {
            return coinCount;
        }

        //change laser count
        public void changeArrowCount(int change)
        {
            arrowCount += change;
        }

        //change energy charges
        public void changeCoinCount(int change)
        {
            coinCount += change;
        }

        //return how many turns have passed
        public int getTurn()
        {
            return turn;
        }

        //update turn count
        public void changeTurn(int change)
        {
            turn += change;
        }

        //calculate and return the score
        public int getScore()
        {
            return 100 - (2 * turn) + coinCount + (10 * arrowCount); 
        }

        //update turns and coins each turn
        public void updateStatus() //should we do it in real time or at the end. If at end, just make this method return score
        {
            turn++;
            if (turn <= 100) {
                coinCount++;
            }
        }
    }
}
