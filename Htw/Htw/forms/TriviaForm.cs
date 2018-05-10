using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using wumpus.components;

namespace wumpus.forms
{
    public partial class TriviaForm : Form
    {
        public TriviaForm(Trivia trivia)
        {
            InitializeComponent();

            questionText.Text = trivia.GetQuestions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            questionText.Text = "Hi";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
