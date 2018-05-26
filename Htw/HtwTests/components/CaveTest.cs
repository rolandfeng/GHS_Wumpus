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

            int[] connectedTo2 = cave.getAllConnections(2); 
            for (int i = 0; i < connectedTo1.Length; i++)
               File.AppendAllText("CaveTestResults.txt", " " + connectedTo1[i]);

            int[] connectedTo3 = cave.getAllConnections(3);
            for (int i = 0; i < connectedTo1.Length; i++)
              File.AppendAllText("CaveTestResults.txt", " " + connectedTo1[i]);

            int[] connectedTo4 = cave.getAllConnections(4);
            for (int i = 0; i < connectedTo1.Length; i++)
               File.AppendAllText("CaveTestResults.txt", " " + connectedTo1[i]);

            int[] connectedTo5 = cave.getAllConnections(5);
            for (int i = 0; i < connectedTo1.Length; i++)
               File.AppendAllText("CaveTestResults.txt", " " + connectedTo1[i]);

            Cave randCave = new Cave("RandCave.txt");
        }
    }
}
