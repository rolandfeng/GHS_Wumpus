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
            Cave cave = new Cave("StandardCave.txt");
            int[] connectedTo3 = cave.getAllConnections(3);
            int[] connectedTo9 = cave.getAllConnections(9);
            int[] connectedTo18 = cave.getAllConnections(18);
            int[] connectedTo5 = cave.getAllConnections(5);
            int[] connectedTo7 = cave.getAllConnections(7);
            int[] connectedTo1 = cave.getAllConnections(1);
            int[] connectedTo2 = cave.getAllConnections(2);

            Cave randCave = new Cave("RandCave2.txt");
            Cave randCave2 = new Cave("RandCave3.txt");
        }
    }
}
