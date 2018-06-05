using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wumpus.forms
{
    public partial class InputForm : Form
    {
        public event EventHandler FormHiding;

        public InputForm()
        {
            InitializeComponent();
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            this.Hide();
            FormHiding.Invoke(this, null);
        }
    }
}
