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

namespace wumpus.forms
{
    public partial class HighScoresForm: Form
    {
        List<HighScore> highScoresList;
        public HighScoresForm()
        {
            InitializeComponent();
        }

        public void setHighScoresList(List<HighScore> highScoresList)
        {
            this.highScoresList = highScoresList;
        }

        public void update()
        {
            Player0.Text = "" + highScoresList.ElementAt(0).getPlayerName();
            Player1.Text = "" + highScoresList.ElementAt(1).getPlayerName();
            Player2.Text = "" + highScoresList.ElementAt(2).getPlayerName();
            Player3.Text = "" + highScoresList.ElementAt(3).getPlayerName();
            Player4.Text = "" + highScoresList.ElementAt(4).getPlayerName();
            Player5.Text = "" + highScoresList.ElementAt(5).getPlayerName();
            Player6.Text = "" + highScoresList.ElementAt(6).getPlayerName();
            Player7.Text = "" + highScoresList.ElementAt(7).getPlayerName();
            Player8.Text = "" + highScoresList.ElementAt(8).getPlayerName();
            Player9.Text = "" + highScoresList.ElementAt(9).getPlayerName();
            HighScore0.Text = "" + highScoresList.ElementAt(0).getHighScore();
            HighScore1.Text = "" + highScoresList.ElementAt(1).getHighScore();
            HighScore2.Text = "" + highScoresList.ElementAt(2).getHighScore();
            HighScore3.Text = "" + highScoresList.ElementAt(3).getHighScore();
            HighScore4.Text = "" + highScoresList.ElementAt(4).getHighScore();
            HighScore5.Text = "" + highScoresList.ElementAt(5).getHighScore();
            HighScore6.Text = "" + highScoresList.ElementAt(6).getHighScore();
            HighScore7.Text = "" + highScoresList.ElementAt(7).getHighScore();
            HighScore8.Text = "" + highScoresList.ElementAt(8).getHighScore();
            HighScore9.Text = "" + highScoresList.ElementAt(9).getHighScore();
            Date0.Text = "" + highScoresList.ElementAt(0).getHighScore();
            Date1.Text = "" + highScoresList.ElementAt(1).getHighScore();
            Date2.Text = "" + highScoresList.ElementAt(2).getHighScore();
            Date3.Text = "" + highScoresList.ElementAt(3).getHighScore();
            Date4.Text = "" + highScoresList.ElementAt(4).getHighScore();
            Date5.Text = "" + highScoresList.ElementAt(5).getHighScore();
            Date6.Text = "" + highScoresList.ElementAt(6).getHighScore();
            Date7.Text = "" + highScoresList.ElementAt(7).getHighScore();
            Date8.Text = "" + highScoresList.ElementAt(8).getHighScore();
            Date9.Text = "" + highScoresList.ElementAt(9).getHighScore();
        }

        private void HighScore1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
