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
using wumpus.forms;

namespace wumpus
{
    public partial class MainMenuForm : Form
    {
        //ScoreManager highscores = new ScoreManager();
        wumpus.forms.Help help = new wumpus.forms.Help();
        public MainMenuForm()
        {
            InitializeComponent();
            Sound test = new Sound();
            test.playSound(Sound.Sounds.MainMenu);
            Cave1.Visible = false;
            Cave2.Visible = false;
            Cave3.Visible = false;
            Cave4.Visible = false;
            Cave5.Visible = false;
            button1.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            Cave1.Visible = true;
            Cave2.Visible = true;
            Cave3.Visible = true;
            Cave4.Visible = true;
            Cave5.Visible = true;
            startGameButton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //highscores.LoadHighScores();
            //highscores.DisplayHighScores();
        }

        private void OpenHelp_Click(object sender, EventArgs e)
        {
            help.Show();
        }

        private void Cave2_Click(object sender, EventArgs e)
        {
            createGame("CaveLayout2.txt");
        }

        private void Cave1_Click(object sender, EventArgs e)
        {
            createGame("StandardCave.txt");
        }

        private void Cave4_Click(object sender, EventArgs e)
        {
            createGame("CaveLayout4.txt");
        }

        private void Cave3_Click(object sender, EventArgs e)
        {
            createGame("CaveLayout3.txt");
        }

        private void Cave5_Click(object sender, EventArgs e)
        {
            createGame("CaveLayout5.txt");
        }

        private void createGame(string cave)
        {
            GameControl gameControl = new GameControl(cave, help);
            gameControl.startGame();
            this.Visible = false;
            gameControl.GameClosing += (send, args) =>
            {
                this.Close();
            };
        }
    }
}
