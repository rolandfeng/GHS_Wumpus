using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.common;

namespace wumpus.components {
    class GameControl {

        public GameControl() {
            Cave newCave = new Cave();
            Graphics newGraphics = new Graphics();
            Map newMap = new Map();
            Sound newSound = new Sound();
            Trivia newTrivia = new Trivia();
            //HighScores newHighScores = new HighScores();
            //Player newPlayer = new Player();
        }

        public void moveRoom(wumpus.common.Direction direction) {
            //wumpus.common.Direction.NORTH_EAST;
        }

        public void shootArrows() {
        
        }
    }
}