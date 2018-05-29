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
            //int[] connectedTo1 = cave.getAllConnections(1);
            //for (int i = 0; i < connectedTo1.Length; i++)
                //File.AppendAllText("CaveTestResults.txt", " " + connectedTo1[i]); // Correct nums are 25, 26, 30, 7, 2, 6

            int[] connectedTo20 = cave.getAllConnections(20); 
            //for (int i = 0; i < connectedTo4.Length; i++)
               //File.AppendAllText("CaveTestResults.txt", " " + connectedTo4[i]);

            int[] connectedTo27 = cave.getAllConnections(27);
            //for (int i = 0; i < connectedTo3.Length; i++)
              //File.AppendAllText("CaveTestResults.txt", " " + connectedTo3[i]);

            int[] connectedTo26 = cave.getAllConnections(26);
            //for (int i = 0; i < connectedTo26.Length; i++)
               //File.AppendAllText("CaveTestResults.txt", " " + connectedTo26[i]);

            int[] connectedTo6 = cave.getAllConnections(6);
            int[] connectedTo12 = cave.getAllConnections(12);
            int[] connectedTo18 = cave.getAllConnections(18);
            int[] connectedTo5 = cave.getAllConnections(5);
            //for (int i = 0; i < connectedTo6.Length; i++)
            //File.AppendAllText("CaveTestResults.txt", " " + connectedTo6[i]);

            int[] connectedTo7 = cave.getAllConnections(7);
            int[] connectedTo1 = cave.getAllConnections(1);
            int[] connectedTo2 = cave.getAllConnections(2);

            Cave randCave = new Cave("RandCave.txt");
        }
    }
}
