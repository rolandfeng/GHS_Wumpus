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
            randomArr = new ArrayList();    //array for random number generator
            fact = new ArrayList();

            //reads file for trivia questions and answers
            String[] lines = File.ReadAllLines("Resource/TriviaQuestions.txt");
            questions = new String[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                questions[i] = lines[i].Split(';');
            }

            //reads file for trivia facts
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
            if (answerCorrect == incrementCorrect)  //if user answers correct # of questions
            {
                triviaForm.Hide();
                numQuestions = 0;
                incrementCorrect = 0;
                gameControl.doneWithTrivia(true, type);
            }
            else if (numQuestions == questionsAsk)  //if max # of questions already asked
            {
                triviaForm.Hide();
                numQuestions = 0;
                incrementCorrect = 0;
                gameControl.doneWithTrivia(false, type);
            }
            else if (incrementCorrect == answerCorrect && numQuestions == questionsAsk) //if max questions asked and correct answered
            {
                triviaForm.Hide();
                numQuestions = 0;
                incrementCorrect = 0;
                gameControl.doneWithTrivia(true, type);
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
                incrementCorrect++;     //increments how many user got correct
            }
            ask(questionsAsk, answerCorrect, type);
        }

        //generates unique random number everytime it is called
        public int randomGenerator()
        {
            if (randomArr.Count == questions.Length)    //resets if all questions already asked 
            {
                randomArr.Clear();
            }
            Random random = new Random();
            int randomIndex = random.Next(0, questions.Length);
            while (randomArr.Contains(randomIndex)) {
                random = new Random();
                randomIndex = random.Next(0, questions.Length);
        }
            randomArr.Add(randomIndex);
            return randomIndex;
        }

        //sets questions and answers for trivia form
        public void askQuestion()   
        {
            int randomIndex = randomGenerator();
            triviaForm.SetQuestion(questions[randomIndex][0]);
            triviaForm.SetAnswer1(questions[randomIndex][1]);
            triviaForm.SetAnswer2(questions[randomIndex][2]);
            triviaForm.SetAnswer3(questions[randomIndex][3]);
            triviaForm.SetAnswer4(questions[randomIndex][4]);

            rightAnswerIndex = Int32.Parse(questions[randomIndex][5]);   //sets index of correct answer 
            triviaForm.SetRightIndex(rightAnswerIndex);

            numQuestions++;     //increments how many questions asked
        }


    }
}
