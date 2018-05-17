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
        private TriviaForm triviaForm;
        private String[][] questions;

        public Trivia()
        {
           triviaForm = new TriviaForm(this);
        }

        public void ShowTrivia()
        {
         triviaForm.Show();
        }

        public bool ask(int questionsAsk, int answerCorrect)
        {
            triviaForm.displayQuestion(questions[0]);
            return false;
        }

       
        
        public String[][] ReadFile()
        {
            String[] lines = File.ReadAllLines("Resource/TriviaQuestions.txt");
            String[][] segments = new String[lines.Length][];
            for(int i = 0; i < lines.Length; i++)
            {
                segments[i] = lines[i].Split(';');
            }
            return segments;
        }

    }
}
