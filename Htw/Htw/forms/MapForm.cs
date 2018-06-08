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
    public partial class MapForm : Form
    {

        public MapForm()
        {
            this.ControlBox = false;
            InitializeComponent();
        }

        public void UpdatePlayerLoc(int newLoc)
        {
            if (newLoc == 1)
                astronaut.Location = new Point(18, 4);
            else if (newLoc == 2)
                astronaut.Location = new Point(123, 56);
            else if (newLoc == 3)
                astronaut.Location = new Point(227, 4);
            else if (newLoc == 4)
                astronaut.Location = new Point(333, 55);
            else if (newLoc == 5)
                astronaut.Location = new Point(435, 2);
            else if (newLoc == 6)
                astronaut.Location = new Point(542, 52);
            else if (newLoc == 7) 
                astronaut.Location = new Point(21, 113);
            else if (newLoc == 8)
                astronaut.Location = new Point(129,168);
            else if (newLoc == 9)
                astronaut.Location = new Point(229, 112);
            else if (newLoc == 10)
                astronaut.Location = new Point(335, 162);
            else if (newLoc == 11)
                astronaut.Location = new Point(438, 108);
            else if (newLoc == 12)
                astronaut.Location = new Point(545, 158);
            else if (newLoc == 13)
                astronaut.Location = new Point(25, 222);
            else if (newLoc == 14)
                astronaut.Location = new Point(132, 275);
            else if (newLoc == 15)
                astronaut.Location = new Point(236, 219);
            else if (newLoc == 16)
                astronaut.Location = new Point(339, 270);
            else if (newLoc == 17)
                astronaut.Location = new Point(441, 214);
            else if (newLoc == 18)
                astronaut.Location = new Point(547, 266);
            else if (newLoc == 19)
                astronaut.Location = new Point(31, 330);
            else if (newLoc == 20)
                astronaut.Location = new Point(137, 382);
            else if (newLoc == 21)
                astronaut.Location = new Point(238, 327);
            else if (newLoc == 22)
                astronaut.Location = new Point(342, 376);
            else if (newLoc == 23)
                astronaut.Location = new Point(443, 320);
            else if (newLoc == 24)
                astronaut.Location = new Point(549, 372);
            else if (newLoc == 25)
                astronaut.Location = new Point(34, 437);
            else if (newLoc == 26)
                astronaut.Location = new Point(138, 488);
            else if (newLoc == 27)
                astronaut.Location = new Point(240, 434);
            else if (newLoc == 28)
                astronaut.Location = new Point(344, 483);
            else if (newLoc == 29)
                astronaut.Location = new Point(446, 428);
            else if (newLoc == 30)
                astronaut.Location = new Point(550, 481);
        }

        private void closeMap_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
