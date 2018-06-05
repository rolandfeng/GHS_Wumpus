using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.forms;
using System.Collections;

namespace wumpus.components
{
    public class Trivia
    {
        private TriviaForm triviaForm;
        private GameControl gameControl;

        private String[][] questions;
        private int questionsAsk;
        private int answerCorrect;
        private int incrementCorrect;
        private int rightAnswerIndex;
        private int numQuestions;
        private int type;

        private ArrayList randomArr;

        private ArrayList fact;
        private int countFact;


        public Trivia(GameControl gameControl)
        {
            triviaForm = new TriviaForm(this);
            this.gameControl = gameControl;
            randomArr = new ArrayList();
            fact = new ArrayList();

            String[] lines = File.ReadAllLines("Resource/TriviaQuestions.txt");
            questions = new String[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                questions[i] = lines[i].Split(';');
            }

            String[] factArr = File.ReadAllLines(path: "Resource/TriviaFacts.txt");
            for (int k = 0; k < factArr.Length; k++)
            {
                fact.Add(factArr[k]);
            }
            countFact = -1;
        }

        public String triviaFact()
        {
            countFact++;
            if (countFact >= fact.Count)
            {
                countFact = 0;
            }
            return (String)fact[countFact];
        }

        public void ShowTrivia()
        {
            triviaForm.Show();
        }

        public void ask(int questionsAsk, int answerCorrect, int type)
        {
            this.questionsAsk = questionsAsk;
            this.answerCorrect = answerCorrect;
            this.type = type;
            if (incrementCorrect == answerCorrect || numQuestions == questionsAsk)
            {
                triviaForm.Hide();
                if (incrementCorrect == answerCorrect && numQuestions == questionsAsk)
                {
                    gameControl.doneWithTrivia(true, type);
                }
                else if (incrementCorrect == answerCorrect)
                {
                    gameControl.doneWithTrivia(true, type);
                }
                else if (numQuestions == questionsAsk)
                {
                    gameControl.doneWithTrivia(false, type);
                }
                numQuestions = 0;
                incrementCorrect = 0;
            }
            else
            {
                askQuestion();
            }
        }

        public void increment()
        {
            if (triviaForm.RightAnswer())
            {
                incrementCorrect++;
            }
            ask(questionsAsk, answerCorrect, type);
        }

        public int randomGenerator()
        {
            if (randomArr.Count == questions.Length)
            {
                randomArr.Clear();
            }
            Random random = new Random();
            int randomIndex = random.Next(0, questions.Length);
            while (randomArr.Contains(randomIndex)) {
                random = new Random();
                randomIndex = random.Next(0, questions.Length);
                randomArr.Add(randomIndex);
        }

            return randomIndex;

        }

        public void askQuestion()
        {
            int randomIndex = randomGenerator();
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
