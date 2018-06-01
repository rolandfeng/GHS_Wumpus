using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    public class Map
    {
        private int[] pitLocations; //2 for now
        private int[] batLocations; //2 for now
        private int wumpusLocation;
        private int playerLocation;
        private bool[] occupiedHazard; //see if a room has a hazard in it or not
        private Random num;

        public Map()
        {
            num = new Random();
            occupiedHazard = new bool[30];
            playerLocation = 1; //start room is always 1
            wumpusLocation = num.Next(2, 31);
            occupiedHazard[wumpusLocation - 1] = true;
            pitLocations = new int[2];
            pitLocations[0] = num.Next(2, 31);
            while (occupiedHazard[pitLocations[0]-1] == true)
            {
                pitLocations[0] = num.Next(2, 31);
            }
            occupiedHazard[pitLocations[0] - 1] = true;
            pitLocations[1] = num.Next(2, 31);
            while (occupiedHazard[pitLocations[1] - 1] == true)
            {
                pitLocations[1] = num.Next(2, 31);
            }
            occupiedHazard[pitLocations[1] - 1] = true;
            batLocations = new int[2];
            batLocations[0] = num.Next(2, 31);
            while (occupiedHazard[batLocations[0] - 1] == true)
            {
                batLocations[0] = num.Next(2, 31);
            }
            occupiedHazard[batLocations[0] - 1] = true;
            batLocations[1] = num.Next(2, 31);
            while (occupiedHazard[pitLocations[1] - 1] == true)
            {
                pitLocations[1] = num.Next(2, 31);
            }
            occupiedHazard[batLocations[1] - 1] = true;
        }

        public int[] getPitLocations()
        {
            return pitLocations;
        }

        public int[] getBatLocations()
        {
            return batLocations;
        }

        public int getWumpusLocation()
        {
            return wumpusLocation;
        }

        public int getPlayerLocation()
        {
            return playerLocation;
        }

        public void changePlayerLocation(int newLoc)
        {
            occupiedHazard[playerLocation - 1] = false;
            playerLocation = newLoc;
            occupiedHazard[playerLocation - 1] = true;
        }

        private void updateHazardCheck(int room, Boolean change) //idk if this is better than what i have been doing
        {
            occupiedHazard[room - 1] = change;
        }

        public bool pitFall()
        {
            if (playerLocation == pitLocations[0] || playerLocation == pitLocations[1])
            {
                return true;
            }
            return false;
        }

        public bool batCheck() //only changes location of player and bat
        {
            if (playerLocation == batLocations[0])
            {
                occupiedHazard[playerLocation - 1] = false;
                playerLocation = num.Next(1, 31);
                occupiedHazard[playerLocation - 1] = true;
                occupiedHazard[batLocations[0] - 1] = false;
                batLocations[0] = num.Next(1, 31);
                while (occupiedHazard[batLocations[0] - 1] == true)
                {
                    pitLocations[0] = num.Next(1, 31);
                }
                occupiedHazard[batLocations[0] - 1] = true;
                return true;
            }
            if (playerLocation == batLocations[1])
            {
                occupiedHazard[playerLocation - 1] = false;
                playerLocation = num.Next(1, 31);
                occupiedHazard[playerLocation - 1] = true;
                occupiedHazard[batLocations[1] - 1] = false;
                batLocations[0] = num.Next(1, 31);
                while (occupiedHazard[batLocations[1] - 1] == true)
                {
                    pitLocations[1] = num.Next(1, 31);
                }
                occupiedHazard[batLocations[1] - 1] = true;
                return true;
            }
            else
            {
                return false;
            }
        }
                    
        public void changeWumpusLocation(int room)
        {
            occupiedHazard[wumpusLocation - 1] = false;
            wumpusLocation = room;
            occupiedHazard[wumpusLocation - 1] = true;
        }
    }
}
