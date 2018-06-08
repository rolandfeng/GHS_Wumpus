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
                astronaut.Location = new Point(63, 38);
            else if (newLoc == 2)
                astronaut.Location = new Point(151, 86);
            else if (newLoc == 3)
                astronaut.Location = new Point(233, 38);
            else if (newLoc == 4)
                astronaut.Location = new Point(322, 86);
            else if (newLoc == 5)
                astronaut.Location = new Point(405, 35);
            else if (newLoc == 6)
                astronaut.Location = new Point(493, 80);
            else if (newLoc == 7)
                astronaut.Location = new Point(65, 133);
            else if (newLoc == 8)
                astronaut.Location = new Point(154, 182);
            else if (newLoc == 9)
                astronaut.Location = new Point(238, 133);
            else if (newLoc == 10)
                astronaut.Location = new Point(324, 179);
            else if (newLoc == 11)
                astronaut.Location = new Point(407, 130);
            else if (newLoc == 12)
                astronaut.Location = new Point(495, 175);
            else if (newLoc == 13)
                astronaut.Location = new Point(69, 230);
            else if (newLoc == 14)
                astronaut.Location = new Point(158, 278);
            else if (newLoc == 15)
                astronaut.Location = new Point(240, 227);
            else if (newLoc == 16)
                astronaut.Location = new Point(326, 273);
            else if (newLoc == 17)
                astronaut.Location = new Point(410, 223);
            else if (newLoc == 18)
                astronaut.Location = new Point(497, 269);
            else if (newLoc == 19)
                astronaut.Location = new Point(74, 327);
            else if (newLoc == 20)
                astronaut.Location = new Point(161, 372);
            else if (newLoc == 21)
                astronaut.Location = new Point(243, 322);
            else if (newLoc == 22)
                astronaut.Location = new Point(330, 367);
            else if (newLoc == 23)
                astronaut.Location = new Point(413, 318);
            else if (newLoc == 24)
                astronaut.Location = new Point(499, 365);
            else if (newLoc == 25)
                astronaut.Location = new Point(77, 422);
            else if (newLoc == 26)
                astronaut.Location = new Point(162, 468);
            else if (newLoc == 27)
                astronaut.Location = new Point(246, 418);
            else if (newLoc == 28)
                astronaut.Location = new Point(331, 463);
            else if (newLoc == 29)
                astronaut.Location = new Point(414, 414);
            else if (newLoc == 30)
                astronaut.Location = new Point(501, 460);
        }

        private void closeMap_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
