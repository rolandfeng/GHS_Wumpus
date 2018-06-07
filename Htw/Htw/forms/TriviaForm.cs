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
        private int rightAnswerIndex;
        private bool answerRight;
        Trivia triviaObject;

        public TriviaForm(Trivia trivia)
        {
            InitializeComponent();
            triviaObject = trivia;
        }

        public void SetQuestion(String question)
        {
            questionText.Text = question;
        }

        public void SetAnswer1(String answer1)
        {
            button1.Text = answer1;
        }

        public void SetAnswer2(String answer2)
        {
            button2.Text = answer2;
        }

        public void SetAnswer3(String answer3)
        {
            button3.Text = answer3;
        }

        public void SetAnswer4(String answer4)
        {
            button4.Text = answer4;
        }

        public void SetRightIndex (int index)
        {
            rightAnswerIndex = index;
        }

        public Boolean RightAnswer()
        {
            return answerRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            if (rightAnswerIndex == x)
            {
                answerRight = true;
            }
            else
            {
                answerRight = false;
            }
            triviaObject.increment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 2;
            if (rightAnswerIndex == x)
            {
                answerRight = true;
            }
            else
            {
                answerRight = false;
            }
            triviaObject.increment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 3;
            if (rightAnswerIndex == x)
            {
                answerRight = true;
            }
            else
            {
                answerRight = false;
            }
            triviaObject.increment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 4;
            if (rightAnswerIndex == x)
            {
                answerRight = true;
            }
            else
            {
                answerRight = false;
            }
            triviaObject.increment();
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

        private void TriviaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
