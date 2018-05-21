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
            wumpusLocation = num.Next(2, 30);
            occupiedHazard[wumpusLocation - 1] = true;
            pitLocations = new int[2];
            pitLocations[0] = num.Next(2, 30);
            while (occupiedHazard[pitLocations[0]-1] == true)
            {
                pitLocations[0] = num.Next(2, 30);
            }
            occupiedHazard[pitLocations[0] - 1] = true;
            pitLocations[1] = num.Next(2, 30);
            while (occupiedHazard[pitLocations[1] - 1] == true)
            {
                pitLocations[1] = num.Next(2, 30);
            }
            occupiedHazard[pitLocations[1] - 1] = true;
            batLocations = new int[2];
            batLocations[0] = num.Next(2, 30);
            while (occupiedHazard[batLocations[0] - 1] == true)
            {
                batLocations[0] = num.Next(2, 30);
            }
            occupiedHazard[batLocations[0] - 1] = true;
            batLocations[1] = num.Next(2, 30);
            while (occupiedHazard[pitLocations[1] - 1] == true)
            {
                pitLocations[1] = num.Next(2, 30);
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
            playerLocation = newLoc;
        }

        /*public bool fireArrow(int destination)
        {
            if (destination == wumpusLocation)
            {
                return true;
            }
            else
            {
                return false;
            }
        } */

        public void updateHazardCheck(int room, Boolean change)
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

        public void batCheck() //only changes location of player and bat
        {
            if (playerLocation == batLocations[0])
            {
                occupiedHazard[playerLocation - 1] = false;
                playerLocation = num.Next(30);
                occupiedHazard[playerLocation - 1] = true;
                occupiedHazard[batLocations[0] - 1] = false;
                batLocations[0] = num.Next(30);
                while (occupiedHazard[batLocations[0] - 1] == true)
                {
                    pitLocations[0] = num.Next(30);
                }
                occupiedHazard[batLocations[0] - 1] = true;
            }
            if (playerLocation == batLocations[1])
            {
                occupiedHazard[playerLocation - 1] = false;
                playerLocation = num.Next(30);
                occupiedHazard[playerLocation - 1] = true;
                occupiedHazard[batLocations[1] - 1] = false;
                batLocations[0] = num.Next(30);
                while (occupiedHazard[batLocations[1] - 1] == true)
                {
                    pitLocations[1] = num.Next(30);
                }
                occupiedHazard[batLocations[1] - 1] = true;
            }
        }
                    

        public void wumpusMovement() //only changes location
        {
            occupiedHazard[wumpusLocation - 1] = false;
            wumpusLocation = num.Next(30);
            occupiedHazard[wumpusLocation - 1] = true;
        } 
    }
}
