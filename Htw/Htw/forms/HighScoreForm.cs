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
    public partial class Form1 : Form
    {
        List<HighScore> highScoresList;
        public Form1()
        {
            InitializeComponent();
        }

        public void setHighScoresList(List<HighScore> highScoresList)
        {
            this.highScoresList = highScoresList;
        }

        public void update()
        {
            HighScore1.Text = "" + highScoresList.ElementAt(0).getHighScore();
        }

        private void HighScore1_Click(object sender, EventArgs e)
        {

        }
    }
}
