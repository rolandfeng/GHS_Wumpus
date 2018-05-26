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
        Direction direction;
        Image[] image;


        public MainGame(GameControl gameControl, Player player, Map map, Cave cave)
        {
            InitializeComponent();
            this.gameControl = gameControl;
            this.player = player;
            this.map = map;
            this.cave = cave;
            this.image = new Image[]{Properties.Resources.planet1, Properties.Resources.planet2, Properties.Resources.planet3,
                                     Properties.Resources.planet4, Properties.Resources.planet5, Properties.Resources.planet6,
                                     Properties.Resources.planet7, Properties.Resources.planet8, Properties.Resources.planet9,
                                     Properties.Resources.planet10, Properties.Resources.planet11, Properties.Resources.planet12,
                                     Properties.Resources.planet13, Properties.Resources.planet14, Properties.Resources.planet15,
                                     Properties.Resources.planet16, Properties.Resources.planet17, Properties.Resources.planet18,
                                     Properties.Resources.planet19, Properties.Resources.planet20, Properties.Resources.planet21,
                                     Properties.Resources.planet22, Properties.Resources.planet23, Properties.Resources.planet24,
                                     Properties.Resources.planet25, Properties.Resources.planet26, Properties.Resources.planet27,
                                     Properties.Resources.planet28, Properties.Resources.planet29, Properties.Resources.planet30 };
        
    }


        public void UpdateGraphics(int currentRoom)
        { 
            //Timer timer = new Timer();
            //timer.Interval = 5000;
            //timer.Tick += delegate (object sender, EventArgs e)
            //{


                // update coins
                NumberOfCoinsLabel.Text = "Number of Coins: " + player.getCoinCount();

                //update arrows
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();

                //update available doors
                int[] connections;
                connections = cave.getAllConnections(currentRoom);
                if (connections[0] == 0)
                {
                    northButton.Visible = false;
                    NorthRoomsLabel.Visible = false;
                }
                else
                {
                    NorthRoomsLabel.Text = "" + connections[0];
                }

                if (connections[1] == 0)
                {
                    northEastButton.Visible = false;
                    NorthEastRoomsLabel.Visible = false;
                }
                else
                {
                    NorthEastRoomsLabel.Text = "" + connections[1];
                }

                if (connections[2] == 0)
                {
                    northWestButton.Visible = false;
                    NorthWestRoomsLabel.Visible = false;
                }
                else
                {
                    NorthWestRoomsLabel.Text = "" + connections[2];
                }

                if (connections[3] == 0)
                {
                    southButton.Visible = false;
                    SouthRoomsLabel.Visible = false;
                }
                else
                {
                    SouthRoomsLabel.Text = "" + connections[3];
                }

                if (connections[4] == 0)
                {
                    southEastButton.Visible = false;
                    SouthEastRoomsLabel.Visible = false;
                }
                else
                {
                    SouthEastRoomsLabel.Text = "" + connections[4];
                }

                if (connections[5] == 0)
                {
                    southWestButton.Visible = false;
                    SouthWestRoomsLabel.Visible = false;
                }
                else
                {
                    SouthWestRoomsLabel.Text = "" + connections[5];
                }

                //update button pictures
                northButton.Image = image[connections[0]-1];
                //messageLabel.Text = "" + connections[1];
                northEastButton.Image = image[connections[1]-1];
                northWestButton.Image = image[connections[2]-1];
                southButton.Image = image[connections[3]-1];
                southEastButton.Image = image[connections[4]-1];
                southWestButton.Image = image[connections[5]-1];



                //update room
                BackgroundImage = image[currentRoom - 1];
                //timer.Stop();
            //};
        }

        private void northButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.NORTH);
            this.direction = Direction.NORTH;
        }

        private void northEastButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.NORTH_EAST);
            this.direction = Direction.NORTH_EAST;
        }

        private void southEastButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.SOUTH_EAST);
            this.direction = Direction.SOUTH_EAST;
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.SOUTH);
            this.direction = Direction.SOUTH;
        }

        private void southWestButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.SOUTH_WEST);
            this.direction = Direction.SOUTH_WEST;
        }

        private void northWestButton_Click(object sender, EventArgs e)
        {
            gameControl.moveRoom(Direction.NORTH_WEST);
            this.direction = Direction.NORTH_WEST;
        }


        private void ShootArrowButton_Click(object sender, EventArgs e)
        {

            gameControl.shootArrows(this.direction);
        }

        private void PurchaseArrowsButton_Click(object sender, EventArgs e)
        {
            gameControl.buyArrows();
        }

        private void buySecretButton_Click(object sender, EventArgs e)
        {
            gameControl.buySecret();
        }
    }
}


