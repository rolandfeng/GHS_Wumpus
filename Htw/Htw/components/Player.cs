using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{
    class Player
    {
        public static int getCurrentLocation();

        public static void changePlayerLocation(int newLocation);

        public static int getArrowCount();

        public static void changeArrowCount(int arrowChange);
    }
}
