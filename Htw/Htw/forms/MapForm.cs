using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wumpus.components;

namespace wumpus.forms
{
    public partial class MapForm : Form
    {
        Map map;
        Cave cave;
        int CurrentRoom;
        int[] ConnectedRooms;

        public MapForm()
        {
            InitializeComponent();
        }

        public MapForm(Map map, Cave cave)
        {
            InitializeComponent();
            this.map = map;
            this.cave = cave;
            CurrentRoom = 1;
        }

        public void UpdatePlayerLoc(int newLoc, int[] NewConnectedRooms)
        {
            if (newLoc == 1)
                astronaut.Location = new Point(62, 41);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 3)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 4)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 5)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 6)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 7)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 8)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 9)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 10)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 11)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 12)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);
            else if (newLoc == 2)
                astronaut.Location = new Point(135, 84);

            CurrentRoom = newLoc;
            ConnectedRooms = NewConnectedRooms;
        }

        private void closeMap_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
