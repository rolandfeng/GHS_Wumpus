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
            CurrentRoom = newLoc;
            ConnectedRooms = NewConnectedRooms;
        }

        private void closeMap_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
