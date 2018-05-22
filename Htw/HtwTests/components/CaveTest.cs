using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtwTests.components
{
    class CaveTest
    {
        public static void Main(String[] args)
        {
            Cave cave = new Cave("StandardCave.txt");
            int[] connectedTo1 = cave.getAllConnections(1);
            for (int i = 0; i < connectedTo1.Length; i++)
                Debug.WriteLine(connectedTo1[i]); // Correct nums are 25, 26, 6, 7, 8, 12
            Debug.WriteLine(cave.getConnectedRoom(19, wumpus.common.Direction.NORTH)); // Should be 0
            Debug.WriteLine(cave.getConnectedRoom(22, wumpus.common.Direction.SOUTH)); // Should be 0
            Debug.WriteLine(cave.getConnectedRoom(16, wumpus.common.Direction.NORTH)); // Should be 0
            Cave altCave = new Cave("AlternativeCave.txt");
            int[] connectedTo22 = altCave.getAllConnections(22);
            foreach (int num in connectedTo22)
                Debug.WriteLine(num); // Correct nums are 16, 17, 15, 0, 28, 27
            Debug.WriteLine(cave.getConnectedRoom(30, wumpus.common.Direction.SOUTH)); // Should be 6
            Debug.WriteLine(cave.getConnectedRoom(30, wumpus.common.Direction.SOUTH_EAST)); // Should be 1
            Debug.WriteLine(cave.getConnectedRoom(1, wumpus.common.Direction.NORTH)); // Should be 25
            Debug.WriteLine(cave.getConnectedRoom(1, wumpus.common.Direction.NORTH_WEST)); // Should be 30
            Cave randCave = new Cave("RandCave.txt");
        }
    }
}
