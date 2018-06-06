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
        bool northClicked;
        bool northWestClicked;
        bool northEastClicked;
        bool southClicked;
        bool southWestClicked;
        bool southEastClicked;
        bool northShootClicked = false;
        bool northWestShootClicked = false;
        bool northEastShootClicked = false;
        bool southShootClicked = false;
        bool southWestShootClicked = false;
        bool southEastShootClicked = false;
        bool timer;
        Image[] image;
        String[] name;
        int spaceshipX;
        int spaceshipY;
        int laserX;
        int laserY;
        int count;
        int currentRoom;

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
            this.northClicked = false;
            this.northWestClicked = false;
            this.northEastClicked = false;
            this.southClicked = false;
            this.southWestClicked = false;
            this.southEastClicked = false;
            this.northShootClicked = false;
            this.northWestShootClicked = false;
            this.northEastShootClicked = false;
            this.southShootClicked = false;
            this.southWestShootClicked = false;
            this.southEastShootClicked = false;
            this.timer = true;
            playAgain.Visible = false;
            quitButton.Visible = false;
            viewHighscores.Visible = false;
            this.image = new Image[]{Properties.Resources.planet1, Properties.Resources.planet2, Properties.Resources.planet3,
                                     Properties.Resources.planet4, Properties.Resources.planet5, Properties.Resources.planet6,
                                     Properties.Resources.planet7, Properties.Resources.planet8, Properties.Resources.planet9,
                                     Properties.Resources.planet10, Properties.Resources.planet11, Properties.Resources.planet12,
                                     Properties.Resources.planet13, Properties.Resources.planet14, Properties.Resources.planet15,
                                     Properties.Resources.planet16, Properties.Resources.planet17, Properties.Resources.planet18,
                                     Properties.Resources.planet19, Properties.Resources.planet20, Properties.Resources.planet21,
                                     Properties.Resources.planet22, Properties.Resources.planet23, Properties.Resources.planet24,
                                     Properties.Resources.planet25, Properties.Resources.planet26, Properties.Resources.planet27,
                                     Properties.Resources.planet28, Properties.Resources.planet29, Properties.Resources.planet30,
                                     Properties.Resources.gameOverWin, Properties.Resources.gameOverLose };
            this.name = new string[] {"Pandora-1", "Aurora-2", "Avalon-3", "Zion-4", "Nova-5",
                                      "Spartania-6", "Artemis-7", "Genesis-8", "Xenon-9", "Orion-10",
                                      "Apollo-11", "Stardust-12", "Hyperion-13", "Divinity-14", "Trinity-15",
                                      "Osiris-16", "Elysium-17", "Nirvana-18", "Styx-19", "Vortex-20",
                                      "Oblivion-21", "Argon-22", "Exodus-23", "Celestial-24", "Equinox-25",            
                                      "Nebula-26", "Andromeda-27", "Galactic-28", "Titanium-29", "Sagittarius-30"};
            this.spaceshipX = 540;
            this.spaceshipY = 300;
            this.laserY = 270;
            this.count = 0;
        }

        // update graphics
        public void UpdateGraphics(int currentRoom)
        {
            this.currentRoom = currentRoom;
            // start timer
            timer1.Enabled = true;

            // laser picture
            arrowPicture.Visible = false;

            // update coins
            NumberOfCoinsLabel.Text = "Number of Coins: " + player.getCoinCount();

            //update arrows
            NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();

            //update available doors
            
            if (count == 0)
            {
                currentRoom = 1;
                northButton.Visible = false;
                NorthRoomsLabel.Visible = false;
                northEastButton.Visible = false;
                NorthEastRoomsLabel.Visible = false;
                northWestButton.Visible = false;
                NorthWestRoomsLabel.Visible = false;
                southEastButton.Visible = false;
                SouthEastRoomsLabel.Visible = false;
                BackgroundImage = image[0];
                count++;
            }
            
            int[] connections;
            connections = cave.getAllConnections(currentRoom);

            /*if (connections[0] == 0) {
                northButton.Visible = false;
                NorthRoomsLabel.Visible = false;
            } else {
                
                    northButton.Visible = true;
                    NorthRoomsLabel.Visible = true;
                    NorthRoomsLabel.Text = name[connections[0] - 1];
                    northButton.Image = image[connections[0] - 1];
                
            }

            if (connections[1] == 0) {
                northEastButton.Visible = false;
                NorthEastRoomsLabel.Visible = false;
            } else {
                    northEastButton.Visible = true;
                    NorthEastRoomsLabel.Visible = true;
                    NorthEastRoomsLabel.Text = name[connections[1] - 1];
                    northEastButton.Image = image[connections[1] - 1];
                
            }

            if (connections[2] == 0) {
                northWestButton.Visible = false;
                NorthWestRoomsLabel.Visible = false;
            } else {
                    northWestButton.Visible = true;
                    NorthWestRoomsLabel.Visible = true;
                    NorthWestRoomsLabel.Text = name[connections[2] - 1];
                    northWestButton.Image = image[connections[2] - 1];
                
            }

            if (connections[3] == 0) {
                southButton.Visible = false;
                SouthRoomsLabel.Visible = false;
            } else {

                    southButton.Visible = true;
                    SouthRoomsLabel.Visible = true;
                    SouthRoomsLabel.Text = name[connections[3] - 1];
                    southButton.Image = image[connections[3] - 1];
              
            }

            if (connections[4] == 0) {
                southEastButton.Visible = false;
                SouthEastRoomsLabel.Visible = false;
            } else {

                    southEastButton.Visible = true;
                    SouthEastRoomsLabel.Visible = true;
                    SouthEastRoomsLabel.Text = name[connections[4] - 1];
                    southEastButton.Image = image[connections[4] - 1];
                
            }

            if (connections[5] == 0) {
                southWestButton.Visible = false;
                SouthWestRoomsLabel.Visible = false;
            } else {
                southWestButton.Visible = true;
                SouthWestRoomsLabel.Visible = true;
                SouthWestRoomsLabel.Text = name[connections[5] - 1];
                southWestButton.Image = image[connections[5] - 1];
            }
            */
            



            //update room
            //BackgroundImage = image[currentRoom - 1];

        }

        // update coins
        public void updateCoins() {
            NumberOfCoinsLabel.Text = "Number of Coins: " + player.getCoinCount();
        }

        public void moveRoom(int currentRoom)
        {
            this.currentRoom = currentRoom;
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
                NorthRoomsLabel.Text = name[connections[0] - 1];
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

        }
        



        // update arrows
        public void updateArrows() {
            NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
        }

        //buttons clicked
        private void northButton_Click(object sender, EventArgs e) {
            if (shootButtonClicked == false) {
                this.northClicked = true;
                gameControl.moveRoom(Direction.NORTH);
                this.direction = Direction.NORTH;
            } else {
                this.direction = Direction.NORTH;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
                this.northShootClicked = true;
            }
        }

        private void northEastButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                this.northEastClicked = true;
                gameControl.moveRoom(Direction.NORTH_EAST);
                this.direction = Direction.NORTH_EAST;
                
            }
            else
            {
                this.direction = Direction.NORTH_EAST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
                this.northEastShootClicked = true;
            }
        }

        private void southEastButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                this.southEastClicked = true;
                gameControl.moveRoom(Direction.SOUTH_EAST);
                this.direction = Direction.SOUTH_EAST;
                
            }
            else
            {
                this.direction = Direction.SOUTH_EAST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
                this.southEastShootClicked = true;
            }
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                this.southClicked = true;
                gameControl.moveRoom(Direction.SOUTH);
                this.direction = Direction.SOUTH;
                
            } 
            else
            {
                this.direction = Direction.SOUTH;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
                this.southShootClicked = true;
            }
        }

        private void southWestButton_Click(object sender, EventArgs e)

        {
            if (shootButtonClicked == false)
            {
                this.southWestClicked = true;
                gameControl.moveRoom(Direction.SOUTH_WEST);
                this.direction = Direction.SOUTH_WEST;
                
            }
            else
            {
                this.direction = Direction.SOUTH_WEST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
                this.southWestShootClicked = true;
            }
        }

        private void northWestButton_Click(object sender, EventArgs e)
        {
            if (shootButtonClicked == false)
            {
                this.northWestClicked = true;
                gameControl.moveRoom(Direction.NORTH_WEST);
                this.direction = Direction.NORTH_WEST;
                
            }
            else
            {
                this.direction = Direction.NORTH_WEST;
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " +  player.getArrowCount();
                shootButtonClicked = false;
                this.northWestShootClicked = true;
            }
        }

        private void ShootArrowButton_Click(object sender, EventArgs e)
        {
            shootButtonClicked = true;
            NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (this.northClicked) {
                this.spaceshipY = this.spaceshipY - 20;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                //System.Diagnostics.Debug.WriteLine(spaceshipPicture.Location.X + "," + spaceshipPicture.Location.Y);
                if (spaceshipPicture.Location.Y == 220) {
                    timer1.Enabled = false;                 
                    this.northClicked = false;
                    this.spaceshipY = 300;
                    BackgroundImage = image[currentRoom - 1];
                    moveRoom(currentRoom);
                }
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
            }

            if (this.northEastClicked)
            {
                this.spaceshipX = this.spaceshipX + 20;
                this.spaceshipY = this.spaceshipY - 4;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                //System.Diagnostics.Debug.WriteLine(spaceshipPicture.Location.X + "," + spaceshipPicture.Location.Y);
                if (spaceshipPicture.Location.X == 900 && spaceshipPicture.Location.Y == 228) {
                    timer1.Enabled = false;
                    this.northEastClicked = false;
                    this.timer = false;
                    this.spaceshipX = 540;
                    this.spaceshipY = 300;
                    BackgroundImage = image[currentRoom - 1];
                    moveRoom(currentRoom);
                }
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
            }

            if (this.northWestClicked)
            {
                this.spaceshipX = this.spaceshipX - 20;
                this.spaceshipY = this.spaceshipY - 4;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                //System.Diagnostics.Debug.WriteLine(spaceshipPicture.Location.X + "," + spaceshipPicture.Location.Y);
                if (spaceshipPicture.Location.X == 300 && spaceshipPicture.Location.Y == 252)
                {
                    timer1.Enabled = false;
                    this.northWestClicked = false;
                    this.timer = false;
                    this.spaceshipX = 540;
                    this.spaceshipY = 300;
                    BackgroundImage = image[currentRoom - 1];
                    moveRoom(currentRoom);
                }
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
            }


            if (this.southClicked)
            {
                this.spaceshipY = this.spaceshipY + 20;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                System.Diagnostics.Debug.WriteLine(spaceshipPicture.Location.X + "," + spaceshipPicture.Location.Y);
                if (spaceshipPicture.Location.Y == 400)
                {
                    //System.Diagnostics.Debug.WriteLine("entered inner if");
                    timer1.Enabled = false;
                    //moveRoom(currentRoom);
                    this.southClicked = false;
                    this.spaceshipY = 300;
                    BackgroundImage = image[currentRoom - 1];
                    moveRoom(currentRoom);
                }
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
            }

            if (this.southEastClicked)
            {
                this.spaceshipX = this.spaceshipX + 20;
                this.spaceshipY = this.spaceshipY + 4;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                //System.Diagnostics.Debug.WriteLine(spaceshipPicture.Location.X + "," + spaceshipPicture.Location.Y);
                if (spaceshipPicture.Location.X == 860 && spaceshipPicture.Location.Y == 364)
                {
                    timer1.Enabled = false;
                    this.southEastClicked = false;
                    this.timer = false;
                    this.spaceshipX = 540;
                    this.spaceshipY = 300;
                    BackgroundImage = image[currentRoom - 1];
                    moveRoom(currentRoom);
                }
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
            }

            if (this.southWestClicked)
            {
                this.spaceshipX = this.spaceshipX - 20;
                this.spaceshipY = this.spaceshipY + 4;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                //System.Diagnostics.Debug.WriteLine(spaceshipPicture.Location.X + "," + spaceshipPicture.Location.Y);
                if (spaceshipPicture.Location.X == 260 && spaceshipPicture.Location.Y == 356)
                {
                    timer1.Enabled = false;
                    this.southWestClicked = false;
                    this.timer = false;
                    this.spaceshipX = 540;
                    this.spaceshipY = 300;
                    BackgroundImage = image[currentRoom - 1];
                    moveRoom(currentRoom);
                }
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
            }


            if (this.northShootClicked == true)
            {
                arrowPicture.Visible = true;
                this.laserX = 535; 
                this.laserY = this.laserY - 5;
                arrowPicture.Location = new Point(laserX, laserY);
                if (arrowPicture.Location.Y == 200)
                {
                    timer1.Enabled = false;
                    arrowPicture.Visible = false;
                }
            }          

        }

        // end game
        public void endGame(bool result)
        {
            northButton.Visible = false;
            northEastButton.Visible = false;
            northWestButton.Visible = false;
            southButton.Visible = false;
            southEastButton.Visible = false;
            southWestButton.Visible = false;
            NorthRoomsLabel.Visible = false;
            NorthEastRoomsLabel.Visible = false;
            NorthWestRoomsLabel.Visible = false;
            SouthRoomsLabel.Visible = false;
            SouthEastRoomsLabel.Visible = false;
            SouthWestRoomsLabel.Visible = false;
            spaceshipPicture.Visible = false;
            arrowPicture.Visible = false;
            NumberOfArrowsLabel.Visible = false;
            NumberOfCoinsLabel.Visible = false;
            PurchaseArrowsButton.Visible = false;
            buySecretButton.Visible = false;
            ShootArrowButton.Visible = false;
            playAgain.Visible = true;
            quitButton.Visible = true;
            viewHighscores.Visible = true;
            if (result) {
                BackgroundImage = Properties.Resources.gameOverWin;
            } else {
                BackgroundImage = Properties.Resources.gameOverLose;
            }
             

        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            gameControl.closeGame();
            gameControl.startGame();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            gameControl.closeGame();
        }

        private void viewHighscores_Click(object sender, EventArgs e)
        {
            gameControl.displayHighscores();
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



