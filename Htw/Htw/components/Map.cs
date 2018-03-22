using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    class Map
    {
        public static int[] getPitLocations();

        public static int[] getBatLocations();

        public static int getWumpuslocation();

        public static int getPlayerLocation();

        private static void batMovement(); //bat ai

        private static void wumpusMovement(); //wumpus ai
    }
}
