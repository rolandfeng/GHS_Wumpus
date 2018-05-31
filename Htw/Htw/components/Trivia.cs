﻿using System;
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
        private GameControl gameControl;
        private String[][] questions;
        private int questionsAsk;
        private int answerCorrect;
        private int incrementCorrect;
        private int rightAnswerIndex;
        private int numQuestions;
        private int type;

        public Trivia(GameControl gameControl)
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

        public void ask(int questionsAsk, int answerCorrect, int type) 
        {
           // bool statement = false;
            this.questionsAsk = questionsAsk;
            this.answerCorrect = answerCorrect;
            this.type = type;
            if (numQuestions == questionsAsk || answerCorrect == incrementCorrect)
            {
                triviaForm.Hide();
                numQuestions = 0;
                incrementCorrect = 0;
            } 
                if (answerCorrect == incrementCorrect)
                {
                    //statement = true;
                gameControl.doneWithTrivia(true, type);
                }
                askQuestion();

            gameControl.doneWithTrivia(false, type);
        }

        public void increment()
        {
            if (triviaForm.RightAnswer())
            {
                incrementCorrect++;
            } 
            ask(questionsAsk, answerCorrect, type); 
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
