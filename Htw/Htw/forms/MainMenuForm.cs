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
        GameControl gameControl = new GameControl();
        public MainMenuForm()
        {
            InitializeComponent();
            Sound test = new Sound();
            test.playSound(Sound.Sounds.MainMenu);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            gameControl.startGame();
            this.Visible = false;
            gameControl.GameClosing += (send, args) =>
            {
                this.Close();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameControl.displayHighscores();
        }
    }
}
