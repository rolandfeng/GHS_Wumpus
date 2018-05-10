using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.forms;

namespace wumpus.components
{
    public class Trivia
    {
        public Trivia()
        {
            TriviaForm TriviaForm = new TriviaForm(this);
            TriviaForm.Show();
            //generate different number of buttons for possible trivia answers
        }
        public Boolean ask(int questionsAsk, int answerCorrect)
        {
            //read triviaQuestions file and print out question on form

            return false;
        }

        //separate method to read files

        public String GetQuestions()
        {
            String[] lines = File.ReadAllLines("Resource/TriviaQuestions.txt");
            String[] segments = new String[lines.Length];
            foreach (String line in lines)
            {
                segments = line.Split(';');
            }
            int QuestionNumber = 0;
            return segments[QuestionNumber];

        }

        public String GetAnswers()
        {

            return null;
        }

    }
}
