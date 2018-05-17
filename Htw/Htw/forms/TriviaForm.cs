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
            
        }

        public void displayQuestion(String[] trivia)
        { 
            questionText.Text = trivia[0];
            button1.Text = trivia[1];
            button2.Text = trivia[2];
            button3.Text = trivia[3];
            button4.Text = trivia[4];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

        private void TriviaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
