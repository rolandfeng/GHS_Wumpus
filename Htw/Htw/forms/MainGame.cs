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
using System.Drawing.Drawing2D;

namespace wumpus.forms
{
    public partial class MainGame : Form
    {
        GameControl gameControl;
        Player player;
        Map map;
        Cave cave;
        Direction direction;
        bool shootButtonClicked;
        Image[] image;
        String[] name;



        public MainGame(GameControl gameControl, Player player, Map map, Cave cave)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.gameControl = gameControl;
            this.player = player;
            this.map = map;
            this.cave = cave;
            this.shootButtonClicked = false;
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
            this.name = new string[] {"Pandora-1", "Aurora-2", "Avalon-3", "Zion-4", "Nova-5",
                                      "Spartania-6", "Artemis-7", "Genesis-8", "Xenon-9", "Orion-10",
                                      "Apollo-11", "Stardust-12", "Hyperion-13", "Divinity-14", "Trinity-15",
                                      "Osiris-16", "Elysium-17", "Nirvana-18", "Styx-19", "Vortex-20",
                                      "Oblivion-21", "Argon-22", "Exodus-23", "Celestial-24", "Equinox-25",            
                                      "Nebula-26", "Andromeda-27", "Galactic-28", "Titanium-29", "Sagittarius-30"};
        }


        public void UpdateGraphics(int currentRoom)
        {
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
                northButton.Visible = true;
                NorthRoomsLabel.Visible = true;
                NorthRoomsLabel.Text = name[connections[0]-1];
                northButton.Image = image[connections[0] - 1];
            }

            if (connections[1] == 0)
            {
                northEastButton.Visible = false;
                NorthEastRoomsLabel.Visible = false;
            }
            else
            {
                northEastButton.Visible = true;
                NorthEastRoomsLabel.Visible = true;
                NorthEastRoomsLabel.Text = name[connections[1] - 1];
                northEastButton.Image = image[connections[1] - 1];
            }

            if (connections[2] == 0)
            {
                northWestButton.Visible = false;
                NorthWestRoomsLabel.Visible = false;
            }
            else
            {
                northWestButton.Visible = true;
                NorthWestRoomsLabel.Visible = true;
                NorthWestRoomsLabel.Text = name[connections[2] - 1];
                northWestButton.Image = image[connections[2] - 1];
            }

            if (connections[3] == 0)
            {
                southButton.Visible = false;
                SouthRoomsLabel.Visible = false;
            }
            else
            {
                southButton.Visible = true;
                SouthRoomsLabel.Visible = true;
                SouthRoomsLabel.Text = name[connections[3] - 1];
                southButton.Image = image[connections[3] - 1];
            }

            if (connections[4] == 0)
            {
                southEastButton.Visible = false;
                SouthEastRoomsLabel.Visible = false;
            }
            else
            {
                southEastButton.Visible = true;
                SouthEastRoomsLabel.Visible = true;
                SouthEastRoomsLabel.Text = name[connections[4] - 1];
                southEastButton.Image = image[connections[4] - 1];
            }

            if (connections[5] == 0)
            {
                southWestButton.Visible = false;
                SouthWestRoomsLabel.Visible = false;
            }
            else
            {
                southWestButton.Visible = true;
                SouthWestRoomsLabel.Visible = true;
                SouthWestRoomsLabel.Text = name[connections[5] - 1];
                southWestButton.Image = image[connections[5] - 1];
            }
            //update room
            BackgroundImage = image[currentRoom - 1];
            
            //planetButton.BackgroundImage = image[currentRoom - 1];
        }


        //buttons clicked
        private void northButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                gameControl.moveRoom(Direction.NORTH);
                this.direction = Direction.NORTH;
            }
            else
            {
                this.direction = Direction.NORTH;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
            }
        }

        private void northEastButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                gameControl.moveRoom(Direction.NORTH_EAST);
                this.direction = Direction.NORTH_EAST;
            }
            else
            {
                this.direction = Direction.NORTH_EAST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
            }
        }

        private void southEastButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                gameControl.moveRoom(Direction.SOUTH_EAST);
                this.direction = Direction.SOUTH_EAST;
            }
            else
            {
                this.direction = Direction.SOUTH_EAST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
            }
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                gameControl.moveRoom(Direction.SOUTH);
                this.direction = Direction.SOUTH;
            } 
            else
            {
                this.direction = Direction.SOUTH;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
            }
        }

        private void southWestButton_Click(object sender, EventArgs e)

        {
            if (shootButtonClicked == false)
            {
                gameControl.moveRoom(Direction.SOUTH_WEST);
                this.direction = Direction.SOUTH_WEST;
            }
            else
            {
                this.direction = Direction.SOUTH_WEST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
            }
        }

        private void northWestButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                gameControl.moveRoom(Direction.NORTH_WEST);
                this.direction = Direction.NORTH_WEST;
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
            }
            else
            {
                this.direction = Direction.NORTH_WEST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
            }
        }

        private void ShootArrowButton_Click(object sender, EventArgs e)
        {
            shootButtonClicked = true;

        }

        private void PurchaseArrowsButton_Click(object sender, EventArgs e)
        {
            gameControl.buyArrows();
            NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
        }

        private void buySecretButton_Click(object sender, EventArgs e)
        {
            gameControl.buySecret();
        }

    }
}

public class RoundButton : Button
{
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        GraphicsPath grPath = new GraphicsPath();
        grPath.AddEllipse(200, 200, 100, 100);
        this.Region = new System.Drawing.Region(grPath);
        base.OnPaint(e);
    }
}



