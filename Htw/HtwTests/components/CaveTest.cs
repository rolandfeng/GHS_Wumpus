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
            Cave cave = new Cave("StandardCave");
            int[] connectedTo1 = cave.getAllConnections(1);
            for (int i = 0; i < connectedTo1.Length; i++)
                Debug.WriteLine(connectedTo1[i]);
        }
    }
}
