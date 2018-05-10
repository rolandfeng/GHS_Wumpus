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
using wumpus.components;

namespace wumpus.forms
{
    public partial class MainGame : Form
    {
        GameControl gameControl; 

        public MainGame(GameControl gameControl)
        {
            InitializeComponent();
            this.gameControl = gameControl;
        }

        private void northButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.NORTH);
            //return Direction.NORTH;
        }

        private void northEastButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.NORTH_EAST);
            //return Direction.NORTH_EAST;
        }

        private void southEastButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.SOUTH_EAST);
            //return Direction.SOUTH_EAST;
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.SOUTH);
            //return Direction.SOUTH;
        }

        private void southWestButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.SOUTH_WEST);
            //return Direction.SOUTH_WEST;
        }

        private void northWestButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.NORTH_WEST);
            //return Direction.NORTH_WEST;
        }
    }
}
