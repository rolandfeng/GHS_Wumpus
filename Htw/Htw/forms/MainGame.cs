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
        Image[] image;
        System.Timers.Timer timer;

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
            this.timer = new System.Timers.Timer(10000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            timer.Interval = 100;
        }


        public void UpdateGraphics(int currentRoom)
        {
            /*System.Diagnostics.Debug.WriteLine("HELLO2");
            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Interval = 2000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            timer.Start();*/

            System.Diagnostics.Debug.WriteLine("HELLO2");
            timer.Enabled = true;
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
                    NorthRoomsLabel.Text = "" + connections[0];
                    northButton.Image = image[connections[0] - 1];
                }

                if (connections[1] == 0)
                {
                    northEastButton.Visible = false;
                    NorthEastRoomsLabel.Visible = false;
                }
                else
                {
                    NorthEastRoomsLabel.Text = "" + connections[1];
                    northEastButton.Image = image[connections[1] - 1];
                }

                if (connections[2] == 0)
                {
                    northWestButton.Visible = false;
                    NorthWestRoomsLabel.Visible = false;
                }
                else
                {
                    NorthWestRoomsLabel.Text = "" + connections[2];
                    northWestButton.Image = image[connections[2] - 1];
                }

                if (connections[3] == 0)
                {
                    southButton.Visible = false;
                    SouthRoomsLabel.Visible = false;
                }
                else
                {
                    SouthRoomsLabel.Text = "" + connections[3];
                    southButton.Image = image[connections[3] - 1];
                }

                if (connections[4] == 0)
                {
                    southEastButton.Visible = false;
                    SouthEastRoomsLabel.Visible = false;
                }
                else
                {
                    SouthEastRoomsLabel.Text = "" + connections[4];
                    southEastButton.Image = image[connections[4] - 1];
                }

                if (connections[5] == 0)
                {
                    southWestButton.Visible = false;
                    SouthWestRoomsLabel.Visible = false;
                }
                else
                {
                    SouthWestRoomsLabel.Text = "" + connections[5];
                    southWestButton.Image = image[connections[5] - 1];
                }
                //update room
                BackgroundImage = image[currentRoom - 1];

                System.Drawing.Graphics formGraphics = this.CreateGraphics();
                string drawString = "Sample Text";
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                float x = 150.0F;
                float y = 50.0F;
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                //drawFont.Dispose();
                //drawBrush.Dispose();
                //formGraphics.Dispose();

                // stop timer
                //timer.Stop();
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("HELLO");
            int fadingSpeed = 3;
            int opacityFadingSpeed = -10;
            //messageLabel.ForeColor = Color.FromArgb(updateColorNum(messageLabel.ForeColor.A, opacityFadingSpeed), updateColorNum(messageLabel.ForeColor.R, fadingSpeed), updateColorNum(messageLabel.ForeColor.G, fadingSpeed), updateColorNum(messageLabel.ForeColor.B, fadingSpeed));
            //messageLabel.BackColor = Color.FromArgb(updateColorNum(messageLabel.BackColor.A, opacityFadingSpeed), updateColorNum(messageLabel.BackColor.R, fadingSpeed), updateColorNum(messageLabel.BackColor.G, fadingSpeed), updateColorNum(messageLabel.BackColor.B, fadingSpeed));
            messageLabel.ForeColor = Color.Transparent;
            if (messageLabel.ForeColor.R < 244 || messageLabel.ForeColor.G < 244 || messageLabel.ForeColor.B < 244)
            {
                messageLabel.ForeColor = Color.FromArgb(updateColorNum(messageLabel.ForeColor.A, opacityFadingSpeed), updateColorNum(messageLabel.ForeColor.R, fadingSpeed), updateColorNum(messageLabel.ForeColor.G, fadingSpeed), updateColorNum(messageLabel.ForeColor.B, fadingSpeed));
            } else
            {
                messageLabel.BackColor = Color.FromArgb(updateColorNum(messageLabel.BackColor.A, opacityFadingSpeed), updateColorNum(messageLabel.BackColor.R, fadingSpeed), updateColorNum(messageLabel.BackColor.G, fadingSpeed), updateColorNum(messageLabel.BackColor.B, fadingSpeed));
            }
        }

        private int updateColorNum(int colorNum, int fadingSpeed)
        {
            int updatedColorNum = colorNum + fadingSpeed;
            if (updatedColorNum > 255)
            {
                return 255;
            }
            else if (updatedColorNum < 0) {
                return 0;
            }
            else
            {
                return updatedColorNum;
            }
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

        //private void MainGame_Load(object sender, EventArgs e)
        //{

        //}
    }
}

public class RoundButton : Button
{
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        GraphicsPath grPath = new GraphicsPath();
        grPath.AddEllipse(100, 100, 50, 50);
        this.Region = new System.Drawing.Region(grPath);
        base.OnPaint(e);
    }
}

