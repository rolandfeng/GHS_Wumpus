using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtwTests.components
{
    [TestClass()]
    public class CaveTest
    {
        [TestMethod()]
        public void initializeTest()  
        {
            Cave cave = new Cave("Resource/StandardCave.txt");
            int[] connectedTo1 = cave.getAllConnections(1);
            for (int i = 0; i < connectedTo1.Length; i++)
                File.AppendAllText("CaveTestResults.txt", " " + connectedTo1[i]); // Correct nums are 25, 26, 30, 7, 2, 6
            File.AppendAllText("CaveTestResults.txt", "" + cave.getConnectedRoom(19, wumpus.common.Direction.NORTH)); // Should be 0
            File.AppendAllText("CaveTestResults.txt", "" + cave.getConnectedRoom(22, wumpus.common.Direction.SOUTH)); // Should be 0
            File.AppendAllText("CaveTestResults.txt", "" + cave.getConnectedRoom(16, wumpus.common.Direction.NORTH)); // Should be 0
            Cave altCave = new Cave("AlternativeCave.txt");
            int[] connectedTo22 = altCave.getAllConnections(22);
            foreach (int num in connectedTo22)
                File.AppendAllText("CaveTestResults.txt", " " + num); // Correct nums are 16, 17, 15, 0, 28, 27
            File.AppendAllText("CaveTestResults.txt", " " + cave.getConnectedRoom(30, wumpus.common.Direction.SOUTH)); // Should be 6
            File.AppendAllText("CaveTestResults.txt", " " + cave.getConnectedRoom(30, wumpus.common.Direction.SOUTH_EAST)); // Should be 1
            File.AppendAllText("CaveTestResults.txt", " " + cave.getConnectedRoom(1, wumpus.common.Direction.NORTH)); // Should be 25
            File.AppendAllText("CaveTestResults.txt", " " + cave.getConnectedRoom(1, wumpus.common.Direction.NORTH_WEST)); // Should be 30
            Cave randCave = new Cave("RandCave.txt");
        }
    }
}
