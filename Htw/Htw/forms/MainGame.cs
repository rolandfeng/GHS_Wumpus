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
        bool northShootClicked;
        bool northWestShootClicked;
        bool northEastShootClicked;
        bool southShootClicked;
        bool southWestShootClicked;
        bool southEastShootClicked;
        Image[] image;
        String[] name;
        bool timer;
        int spaceshipX;
        int spaceshipY;
        int[] laserX;
        int[] laserY;
        int count;
        int currentRoom;
        bool arrowAnimationFinished;

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
                                      "Spartan-6", "Artemis-7", "Genesis-8", "Xenon-9", "Orion-10",
                                      "Apollo-11", "Stardust-12", "Hyperion-13", "Divinity-14", "Trinity-15",
                                      "Osiris-16", "Elysium-17", "Nirvana-18", "Styx-19", "Vortex-20",
                                      "Oblivion-21", "Argon-22", "Exodus-23", "Celestial-24", "Equinox-25",            
                                      "Nebula-26", "Andromeda-27", "Galactic-28", "Titanium-29", "Sagittarius-30"};
            this.spaceshipX = 540;
            this.spaceshipY = 300;
            this.laserY = new int [] { 270, 300, 330, 400};
            this.laserX = new int[] { 500, 540, 600 };
            this.count = 0;
            this.arrowAnimationFinished = false;
        }

        // update graphics
        public void UpdateGraphics(int currentRoom)
        {
            this.currentRoom = currentRoom;
            updateRooms(currentRoom);

            // laser picture
            laserNorthPicture.Visible = false;
            laserNorthEastPicture.Visible = false;
            laserNorthWestPicture.Visible = false;
            laserSouthPicture.Visible = false;
            laserSouthEastPicture.Visible = false;
            laserSouthWestPicture.Visible = false;

            // update coins
            NumberOfCoinsLabel.Text = "Number of Coins: " + player.getCoinCount();

            //update arrows
            NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();

      
        }

        // update coins
        public void updateCoins() {
            NumberOfCoinsLabel.Text = "Number of Coins: " + player.getCoinCount();
        }

        public void changeRoom(RoundButton button, Label label, int currentRoom, int direction, int[] connections)
        {
            if (connections[direction] == 0)
            {
                button.Visible = false;
                label.Visible = false;
            }
            else
            {
                button.Visible = true;
                label.Visible = true;
                label.Text = name[connections[direction] - 1];
                button.Image = image[connections[direction] - 1];
            }
        }

        // update rooms
        public void updateRooms(int currentRoom)
        {
            this.currentRoom = currentRoom;
            int[] connections;
            connections = cave.getAllConnections(currentRoom);
            RoundButton[] buttonArray = { northButton, northEastButton, northWestButton, southButton, southEastButton, southWestButton };
            planetLabel.Text = "Current Planet: " + name[currentRoom - 1];

            Label[] labelArray = { NorthRoomsLabel, NorthEastRoomsLabel, NorthWestRoomsLabel, SouthRoomsLabel, SouthEastRoomsLabel, SouthWestRoomsLabel };
            for (int i = 0; i < 6; i++)
            {
                changeRoom(buttonArray[i], labelArray[i], currentRoom, i, connections);
            }
        }
        

        public void buttonClick(bool directionClicked, Direction direction, bool directionShootClicked)
        {
            if (shootButtonClicked)
            {
                gameControl.shootArrows(this.direction);
                NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
                shootButtonClicked = false;
                this.arrowAnimationFinished = false;
                timer2.Enabled = true;
            }
            else
            {
                // start timer
                timer1.Enabled = true;
                
            }
        }

        //buttons clicked
        private void northButton_Click(object sender, EventArgs e) {
            this.direction = Direction.NORTH;
            if (shootButtonClicked)
            {
                this.northShootClicked = true;
            }
            else
            {
                this.northClicked = true;
            }
            buttonClick(this.northClicked, Direction.NORTH, this.northShootClicked);
        }

        private void northEastButton_Click(object sender, EventArgs e)
        {
            this.direction = Direction.NORTH_EAST;
            if (shootButtonClicked)
            {
                this.northEastShootClicked = true;
            }
            else
            {
                this.northEastClicked = true;
            }
            buttonClick(this.northEastClicked, Direction.NORTH_EAST, this.northEastShootClicked);
        }

        private void southEastButton_Click(object sender, EventArgs e)
        {
            this.direction = Direction.SOUTH_EAST;
            if (shootButtonClicked)
            {
                this.southEastShootClicked = true;
            }
            else
            {
                this.southEastClicked = true;
            }
            buttonClick(this.southEastClicked, Direction.SOUTH_EAST, this.southEastShootClicked);
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            this.direction = Direction.SOUTH;
            if (shootButtonClicked)
            {
                this.southShootClicked = true;

            }
            else
            {
                this.southClicked = true;
            }
            buttonClick(this.southClicked, Direction.SOUTH, this.southShootClicked);
        }

        private void southWestButton_Click(object sender, EventArgs e)
        {
            this.direction = Direction.SOUTH_WEST;
            if (shootButtonClicked)
            {
                this.southWestShootClicked = true;
            }
            else
            {
                this.southWestClicked = true;
            }
            buttonClick(this.southWestClicked, Direction.SOUTH_WEST, this.southWestShootClicked);
        }

        private void northWestButton_Click(object sender, EventArgs e)
        {
            this.direction = Direction.NORTH_WEST;
            if (shootButtonClicked)
            {
                this.northWestShootClicked = true;
            }
            else
            {
                this.northWestClicked = true;
            }
            buttonClick(this.northWestClicked, Direction.NORTH_WEST, this.northWestShootClicked);

        }

        // update arrows
        public void updateArrows()
        {
            NumberOfArrowsLabel.Text = "Number of Arrows: " + player.getArrowCount();
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
        
        private void animationCompleted()
        {
            timer1.Enabled = false;
            this.timer = false;

            Timer endOfAnimationTimer = new Timer();
            endOfAnimationTimer.Interval = 800;
            endOfAnimationTimer.Tick += (s, e) =>
            {
                BackgroundImage = image[currentRoom - 1];
                this.spaceshipX = 540;
                this.spaceshipY = 300;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                endOfAnimationTimer.Enabled = false;
                endOfAnimationTimer.Stop();
                gameControl.moveRoom(direction);
            };
            endOfAnimationTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (this.northClicked) {
                this.spaceshipY = this.spaceshipY - 20;
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
                //System.Diagnostics.Debug.WriteLine(spaceshipPicture.Location.X + "," + spaceshipPicture.Location.Y);
                if (spaceshipPicture.Location.Y == 220) {
                    this.northClicked = false;
                    animationCompleted();
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
                    
                    this.northEastClicked = false;
                    animationCompleted();
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
                    this.northWestClicked = false;
                    animationCompleted();
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
                    this.southClicked = false;
                    animationCompleted();

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
                    this.southEastClicked = false;
                    animationCompleted();

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
                    this.southWestClicked = false;
                    animationCompleted();

                }
                spaceshipPicture.Location = new Point(spaceshipX, spaceshipY);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.northShootClicked)
            {
                laserNorthPicture.Visible = true;
                laserY[0] = laserY[0] - 5;
                laserNorthPicture.Location = new Point(laserX[0], laserY[0]);
                System.Diagnostics.Debug.WriteLine(laserNorthPicture.Location.X + "," + laserNorthPicture.Location.Y);
                if (laserNorthPicture.Location.Y == 190)
                {
                    timer2.Enabled = false;
                    laserNorthPicture.Visible = false;
                    this.northShootClicked = false;
                    laserY[0] = 270;
                    this.arrowAnimationFinished = true;
                }
            }

            if (this.northEastShootClicked)
            {
                laserNorthEastPicture.Visible = true;
                laserX[2] = laserX[2] + 20;
                laserY[1] = laserY[1] - 4;
                laserNorthEastPicture.Location = new Point(laserX[2], laserY[1]);
                System.Diagnostics.Debug.WriteLine(laserNorthEastPicture.Location.X + "," + laserNorthEastPicture.Location.Y);
                if (laserNorthEastPicture.Location.X == 960 && laserNorthEastPicture.Location.Y == 228)
                {
                    timer2.Enabled = false;
                    laserNorthEastPicture.Visible = false;
                    this.northEastShootClicked = false;
                    laserY[1] = 300;
                    laserX[2] = 600;
                    this.arrowAnimationFinished = true;
                }
            }

            if (this.northWestShootClicked)
            {
                laserNorthWestPicture.Visible = true;
                laserX[0] = laserX[0] - 20;
                laserY[1] = laserY[1] - 4;
                laserNorthWestPicture.Location = new Point(laserX[0], laserY[1]);
                System.Diagnostics.Debug.WriteLine(laserNorthWestPicture.Location.X + "," + laserNorthWestPicture.Location.Y);
                if (laserNorthWestPicture.Location.X == 280 && laserNorthWestPicture.Location.Y == 256)
                {
                    timer2.Enabled = false;
                    laserNorthWestPicture.Visible = false;
                    this.northWestShootClicked = false;
                    laserY[1] = 300;
                    laserX[0] = 500;
                    this.arrowAnimationFinished = true;
                }
            }


            if (this.southShootClicked == true)
            {
                laserSouthPicture.Visible = true;
                laserY[3] = laserY[3] + 5;
                laserSouthPicture.Location = new Point(laserX[1], laserY[3]);
                System.Diagnostics.Debug.WriteLine(laserSouthPicture.Location.X + "," + laserSouthPicture.Location.Y);
                if (laserSouthPicture.Location.Y == 460)
                {
                    timer2.Enabled = false;
                    laserSouthPicture.Visible = false;
                    this.southShootClicked = false;
                    laserY[3] = 400;
                    this.arrowAnimationFinished = true;
                }
            }

            if (this.southEastShootClicked)
            {
                laserSouthEastPicture.Visible = true;
                laserX[2] = laserX[2] + 20;
                laserY[2] = laserY[2] + 4;
                laserSouthEastPicture.Location = new Point(laserX[2], laserY[2]);
                System.Diagnostics.Debug.WriteLine(laserSouthEastPicture.Location.X + "," + laserSouthEastPicture.Location.Y);
                if (laserSouthEastPicture.Location.X == 960 && laserSouthEastPicture.Location.Y == 402)
                {
                    timer2.Enabled = false;
                    laserSouthEastPicture.Visible = false;
                    this.southEastShootClicked = false;
                    laserY[2] = 330;
                    laserX[2] = 600;
                    this.arrowAnimationFinished = true;
                }
            }

            if (this.southWestShootClicked)
            {
                laserSouthWestPicture.Visible = true;
                laserX[0] = laserX[0] - 20;
                laserY[2] = laserY[2] + 4;
                laserSouthWestPicture.Location = new Point(laserX[0], laserY[2]);
                System.Diagnostics.Debug.WriteLine(laserSouthWestPicture.Location.X + "," + laserSouthWestPicture.Location.Y);
                if (laserSouthWestPicture.Location.X == 260 && laserSouthWestPicture.Location.Y == 378)
                {
                    timer2.Enabled = false;
                    laserSouthWestPicture.Visible = false;
                    this.southWestShootClicked = false;
                    laserY[2] = 330;
                    laserX[0] = 500;
                    this.arrowAnimationFinished = true;
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
            laserNorthPicture.Visible = false;
            NumberOfArrowsLabel.Visible = false;
            NumberOfCoinsLabel.Visible = false;
            PurchaseArrowsButton.Visible = false;
            buySecretButton.Visible = false;
            ShootArrowButton.Visible = false;
            planetLabel.Visible = false;
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
            MainMenuForm playAgain = new MainMenuForm();
            playAgain.Show();
            this.Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            gameControl.closeGame();
        }

        private void viewHighscores_Click(object sender, EventArgs e)
        {
            gameControl.displayHighscores();
        }

        

        public bool getArrowAnimationFinished()
        {
            return this.arrowAnimationFinished;
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



