using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.common;

namespace wumpus.components {
    public class GameControl {
        private Cave cave;
        private Graphics graphics;
        private Map map;
        private Sound sound;
        private Trivia trivia;
        private ScoreManager highscores;
        private Player player;

        public GameControl() {
            cave = new Cave("../../Resource/StandardCave.txt");
            map = new Map();
            sound = new Sound();
            trivia = new Trivia();
            highscores = new ScoreManager();
            player = new Player();
            graphics = new Graphics(this, player, map, cave);
        }

        public void moveRoom(wumpus.common.Direction direction) {
            int currentLoc = map.getPlayerLocation();
            int newLoc = cave.getConnectedRoom(currentLoc, direction);
            bool[] hazards = getHazardArray(newLoc);
            map.changePlayerLocation(newLoc);
            //player.updateScore();
            graphics.update(newLoc, hazards);
            //sound.update(hazards);      
            //
            if (map.pitFall()) {
                pitInstance();
            }
            map.batCheck();
            if (newLoc == map.getWumpusLocation()) {
                if (openTrivia(5, 3)) {
                    map.wumpusMovement(true);
                } else {
                    //end game
                }  
            }
        }

        public void shootArrows(wumpus.common.Direction direction) {
            player.changeArrowCount(-1);
            int currentLoc = map.getPlayerLocation();
            if (map.getWumpusLocation() == cave.getConnectedRoom(currentLoc, direction)) {
                //call on graphics method to display victory message
                int playerScore = player.getScore();
                /*if (highscores.testScore(playerScore)) {
                    //method to get the user to input their name
                    //method to get the current date
                    //highscores.StoreHighScore(playerScore); 
                    //highscores.DisplayHighScores();
                }*/
                //end game --- option to play again?
            } else {
                //graphics display message they missed
                map.wumpusMovement(false);
                //continue game
            }
        }

        public void buyArrows() {
            if (openTrivia(3, 2)) {
                player.changeArrowCount(2);
            }
        }

        public bool openTrivia(int asked, int needed) {
            trivia.ShowTrivia();
            return trivia.ask(asked, needed);
        }

        public void pitInstance() {
            bool getOut = false;
            while (getOut) {
                getOut = trivia.ask(3, 2);
            }
            map.changePlayerLocation(1);
        }

        private bool[] getHazardArray(int newLoc) {
            bool[] hazards = new bool[6];
            int wumpusLoc = map.getWumpusLocation();
            if (newLoc == wumpusLoc) {
                hazards[0] = true;
            }
            else if (cave.isAdjacent(newLoc, wumpusLoc)) {
                hazards[1] = true;
            }
            int[] batsLoc = map.getBatLocations();
            int[] pitsLoc = map.getPitLocations();
            if (newLoc == batsLoc[0] || newLoc == batsLoc[1]) {
                hazards[2] = true;
            }
            else if (newLoc == pitsLoc[0] || newLoc == pitsLoc[1]) {
                hazards[4] = true;
            }
            if (cave.isAdjacent(newLoc, batsLoc[0]) || cave.isAdjacent(newLoc, batsLoc[1])) {
                hazards[3] = true;
            }
            if (cave.isAdjacent(newLoc, pitsLoc[0]) || cave.isAdjacent(newLoc, pitsLoc[1])) {
                hazards[5] = true;
            }
            return hazards;
        }

        public void startGame()
        {
            graphics.startGame();
        }
    }
}