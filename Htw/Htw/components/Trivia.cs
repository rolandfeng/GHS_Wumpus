using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.forms;

namespace wumpus.components
{
    class Trivia
    {
        public Trivia()
        {
            TriviaForm TriviaForm = new TriviaForm();
            TriviaForm.Show();
            //generate different number of buttons for possible trivia answers
        }
        public static Boolean ask(int questionsAsk, int answerCorrect)
        {
            //read triviaQuestions file and print out question on form
            
            //List<string> questions = new List<string>();
            string[] lines = File.ReadAllLines("TriviaQuestions.txt");
            foreach(string line in lines)
            {
                string[] segments = line.Split(';');

            }
            for(int i = 0; i < questionsAsk; i++)
            {
                Console.WriteLine(lines[i]);
            }

            
            return false;
        }

    }
}
