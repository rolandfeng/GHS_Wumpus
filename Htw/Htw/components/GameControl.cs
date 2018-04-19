using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.common;

namespace wumpus.components {
    class GameControl {

        public GameControl() {
            Cave cave = new Cave();
            Graphics graphics = new Graphics();
            Map map = new Map();
            Sound sound = new Sound();
            Trivia trivia = new Trivia();
            HighScores highScores = new HighScores();
            Player player = new Player();
        }

        public void moveRoom(wumpus.common.Direction direction) {
            int currentLoc = player.getCurrentLocation();
            int newLoc = cave.getConnectedRoom(currentLoc, direction);
            bool[] hazards = new bool[3];
            int wumpusLoc = map.getWumpus();
            if (wumpusLoc )
            int[] batsLoc = map.getBats();
            int[] pitsLoc = map.getPits();
                                                     
            player.changePlayerLocation(newLoc);
        }

        public void shootArrows() {
        
        }

    }
}