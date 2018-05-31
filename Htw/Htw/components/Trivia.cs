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
        private int questionsAsk;
        private int answerCorrect;
        private int incrementCorrect;
        private int rightAnswerIndex;
        private int numQuestions;

        public Trivia()
        {
            triviaForm = new TriviaForm(this);
            String[] lines = File.ReadAllLines("Resource/TriviaQuestions.txt");
            questions = new String[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                questions[i] = lines[i].Split(';');
            }
        }

        public void ShowTrivia()
        {
            triviaForm.Show();
        }

        public bool ask(int questionsAsk, int answerCorrect) 
        {
            bool statement = false;
            this.questionsAsk = questionsAsk;
            this.answerCorrect = answerCorrect;
            if (numQuestions == questionsAsk)
            {
                triviaForm.Hide();  //Close
            }
            else
            {
                askQuestion();
                if (answerCorrect == incrementCorrect)
                {
                    triviaForm.Hide();  //Close
                    statement = true;
                }
            }
            return statement; 
        }

        public void increment()
        {
            if (triviaForm.RightAnswer())
            {
                incrementCorrect++;
            } 
            ask(questionsAsk, answerCorrect); 
        }

        public void askQuestion()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, questions.Length);
            triviaForm.SetQuestion(questions[randomIndex][0]);
            triviaForm.SetAnswer1(questions[randomIndex][1]);
            triviaForm.SetAnswer2(questions[randomIndex][2]);
            triviaForm.SetAnswer3(questions[randomIndex][3]);
            triviaForm.SetAnswer4(questions[randomIndex][4]);

            rightAnswerIndex = Int32.Parse(questions[randomIndex][5]);
            triviaForm.SetRightIndex(rightAnswerIndex);

            numQuestions++; 
        }


    }
}
