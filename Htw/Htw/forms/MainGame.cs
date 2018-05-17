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
        Player player;
        Map map;
        Cave cave;

        public MainGame(GameControl gameControl, Player player, Map map, Cave cave)
        {
            InitializeComponent();
            this.gameControl = gameControl;
            this.player = player;
            this.map = map;
            this.cave = cave;
        }

        public void UpdateGraphics(int currentRoom, bool[] hazards)
        {
            // update coins
            NumberOfCoinsLabel.Text = "" + player.getCoinCount();

            //update arrows
            NumberOfArrowsLabel.Text = "" + player.getArrowCount();
        

            //update available doors
            int[] connections;
            connections = cave.getAllConnections(currentRoom);
            NorthRoomsLabel.Text = "" + connections[0];
            if (connections[0] == 0)
            {
                northButton.Enabled = false;
            }
            NorthEastRoomsLabel.Text = "" + connections[1];
            if (connections[1] == 0)
            {
                northEastButton.Enabled = false;
            }
            NorthWestRoomsLabel.Text = "" + connections[2];
            if (connections[2] == 0)
            {
                northWestButton.Enabled = false;
            }
            SouthRoomsLabel.Text = "" + connections[3];
            if (connections[3] == 0)
            {
                southButton.Enabled = false;
            }
            SouthEastRoomsLabel.Text = "" + connections[4];
            if (connections[4] == 0)
            {
                southEastButton.Enabled = false;
            }
            SouthWestRoomsLabel.Text = "" + connections[5];
            if (connections[6] == 0)
            {
                southWestButton.Enabled = false;
            }
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


        private void ShootArrowButton_Click(object sender, EventArgs e)
        {
            //gameControl.shootArrow();
        }

        private void PurchaseArrowsButton_Click(object sender, EventArgs e)
        {
            //gameControl.buyArrow();
        }
    }
}
