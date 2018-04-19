using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wumpus.common;

namespace wumpus.forms
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private Direction northButton_Click(object sender, EventArgs e)
        {
            return Direction.NORTH;
        }

        private Direction northEastButton_Click(object sender, EventArgs e)
        {
            return Direction.NORTH_EAST;
        }

        private Direction southEastButton_Click(object sender, EventArgs e)
        {
            return Direction.SOUTH_EAST;
        }

        private Direction southButton_Click(object sender, EventArgs e)
        {
            return Direction.SOUTH;
        }

        private Direction southWestButton_Click(object sender, EventArgs e)
        {
            return Direction.SOUTH_WEST;
        }

        private Direction northWestButton_Click(object sender, EventArgs e)
        {
            return Direction.NORTH_WEST;
        }
    }
}
