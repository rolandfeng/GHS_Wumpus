using System;
using System.Collections.Generic;
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
        }
        public static Boolean ask (int questions, int answer)
        {
            return false;
        }

        private static void readTrivia ()
        {
            
        }

    }
}
