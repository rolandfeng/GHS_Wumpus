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
        public MainMenuForm()
        {
            InitializeComponent();
            Sound test = new Sound();
            test.playSound(Sound.Sounds.DoorClose);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            GameControl initialize = new GameControl();
            MainGame mainGame = new MainGame();
            mainGame.Show();


        }
  

        private void TriviaButton_Click(object sender, EventArgs e)
        {
            TriviaForm testTrivia = new TriviaForm();
            testTrivia.Show();
        }
    }
}
