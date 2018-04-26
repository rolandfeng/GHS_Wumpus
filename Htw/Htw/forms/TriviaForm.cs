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

namespace wumpus.forms
{
    public partial class TriviaForm : Form
    {
        public TriviaForm()
        {
            InitializeComponent();
            //string[] lines = File.ReadAllLines("TriviaQuestions.txt");
           // foreach (string line in lines)
            //{
            //    string[] segments = line.Split(';');
           // }
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
           // textBox2.Text = 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("TriviaQuestions.txt");
            textBox1.Text = lines[0]; 
        }
    }
}
