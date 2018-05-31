using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.common;
using wumpus.forms;

namespace wumpus.components {
    public class GameControl {
        private Cave cave;
        private Graphics graphics;
        private Map map;
        private Sound sound;
        private Trivia trivia;
        private InputForm form;
        private ScoreManager highscores;
        private Player player;

        public GameControl() {
            cave = new Cave("../../Resource/StandardCave.txt");
            map = new Map();
            sound = new Sound();
            trivia = new Trivia();
            form = new InputForm();
            highscores = new ScoreManager(form.getName());
            player = new Player();
            graphics = new Graphics(this, player, map, cave);
        }

        public void moveRoom(wumpus.common.Direction direction) {
            sound.playSound(Sound.Sounds.PlayerWalk);
            int currentLoc = map.getPlayerLocation();
            System.Diagnostics.Debug.WriteLine("Direction: " + direction);
            int newLoc = cave.getConnectedRoom(currentLoc, direction);
            bool[] hazards = getHazardArray(newLoc);
            map.changePlayerLocation(newLoc);
            player.updateStatus();
            graphics.update(newLoc);
            hazardWarnings(hazards);
            if (map.pitFall()) {
                pitInstance();
            }
            map.batCheck();
            if (newLoc == map.getWumpusLocation()) {
                if (openTrivia(5, 3)) {
                    sound.playSound(Sound.Sounds.TriviaRight);
                    //graphics.Show("You survived the Wumpus and forced it to flee!");
                    sound.playSound(Sound.Sounds.MonsterWalk);
                    map.changeWumpusLocation(wumpusFleeLoc(true));
                } else {
                    sound.playSound(Sound.Sounds.TriviaWrong);
                    //graphics.Show("Game Over");
                    sound.playSound(Sound.Sounds.PlayerDie);
                    //end game
                }
            }
        }

        public void shootArrows(wumpus.common.Direction direction) {
            player.changeArrowCount(-1);
            int currentLoc = map.getPlayerLocation();
            if (map.getWumpusLocation() == cave.getConnectedRoom(currentLoc, direction)) {
                sound.playSound(Sound.Sounds.ArrowImpact);
                sound.playSound(Sound.Sounds.MonsterDie);
                graphics.Show("You killed the Wumpus!");
                int playerScore = player.getScore();
                if (highscores.testScore(playerScore)) {
                    highscores.StoreHighScore(playerScore); 
                }
                highscores.DisplayHighScores();
                //end game --- option to play again?
            } else {
                sound.playSound(Sound.Sounds.ArrowMiss);
                graphics.Show("You missed!");
                if (player.getArrowCount() == 0) {
                    graphics.Show("You ran out of arrows!");
                    sound.playSound(Sound.Sounds.PlayerDie);
                    //end game
                }
                map.changeWumpusLocation(wumpusFleeLoc(false));
            }
        }

        public void buyArrows() {
            if (openTrivia(3, 2)) {
                player.changeArrowCount(2);
                sound.playSound(Sound.Sounds.TriviaRight);
                graphics.Show("Well done!");
            }
            else {
                sound.playSound(Sound.Sounds.TriviaWrong);
                graphics.Show("Better luck next time!");
            }
        }

        public bool openTrivia(int asked, int needed) {
            if (player.getCoinCount() < asked) {
                sound.playSound(Sound.Sounds.NoError);
                graphics.Show("Not enough coins for this action");
                return false;
            } else {
                player.changeCoinCount(asked * -1);
                trivia.ShowTrivia();
                return trivia.ask(asked, needed);
            }
        }

        public string buySecret() {
            if (openTrivia(3, 2)) {
                sound.playSound(Sound.Sounds.TriviaRight);
                Random r = new Random();
                int whichHint = r.Next(0, 8); //(0, n) = range from 0 to n-1
                if (whichHint == 0 || whichHint == 1) { //bat rooms
                    int[] bats = map.getBatLocations();
                    return ("There is a bat in room " + bats[whichHint] + "!");
                } else if (whichHint == 2 || whichHint == 3) { //pit rooms
                    int[] pits = map.getPitLocations();
                    return ("There is a pit in room " + pits[whichHint - 2] + "!");
                } else if (whichHint == 4 ) { //Wumpus location
                    return ("The Wumpus is in room " + map.getWumpusLocation() + "!");
                } else if (whichHint == 5) { //bogus hint
                    return ("You are in room " + map.getPlayerLocation() + "!");
                } else if (whichHint == 6) {//Wumpus is 2 rooms away or not
                    if (withinTwoRooms())
                        return ("The Wumpus is 2 rooms away!");
                    else
                        return ("The Wumpus is further than 2 rooms away!");
                } else { //more troll hints, can add more
                    return ("It is turn " + player.getTurn() + "!");
                }
            } else { //false case
                sound.playSound(Sound.Sounds.TriviaWrong);
                return "Better luck next time!";
            }
        }
        public void pitInstance() {
            if (openTrivia(3, 2)) {
                sound.playSound(Sound.Sounds.TriviaRight);
                map.changePlayerLocation(1);
                graphics.Show("You survived the pit!");
            }
            else {
                sound.playSound(Sound.Sounds.TriviaWrong);
                graphics.Show("You succumbed to the pit!");
                sound.playSound(Sound.Sounds.PlayerDie);
                //end game
            }
        }

        private bool[] getHazardArray(int newLoc) { //create array of booleans for each obstacle, if near or same room
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

        private void hazardWarnings(bool[] hazards) {
            if (hazards[0]) {//same room as wumpus 
                graphics.Show("You found the Wumpus!");
                sound.playSound(Sound.Sounds.MonsterRoar);
            }
            if (hazards[1]) {//adjacent to wumpus
                graphics.Show("You smell a Wumpus!");
                sound.playSound(Sound.Sounds.MonsterGrowl);
            }
            if (hazards[2]) {//same room as bats
                graphics.Show("You stumbled upon some bats!");
                sound.playSound(Sound.Sounds.BatsInCave);
            }
            if (hazards[3]) {//adjacent to bats
                graphics.Show("Bats nearby!");
                sound.playSound(Sound.Sounds.BatCall);
            }
            if (hazards[4]) {//same room as pits 
                graphics.Show("You fallen into a pit!");
                sound.playSound(Sound.Sounds.ScaryScream);
            }
            if (hazards[5]) {//adjacent to pits
                graphics.Show("You feel a draft...");
                sound.playSound(Sound.Sounds.ScarySound);
            }
        }

        private int wumpusFleeLoc(bool multiple) { 
            Random r = new Random();
            int prevLoc = 0;
            int initialLoc = map.getWumpusLocation();
            int finalLoc = map.getWumpusLocation(); //only temporary
            if (multiple) { //wumpus runs 2-4 rooms away
                int howMany = r.Next(2, 5);
                for (int i = 0; i < howMany; i++) { 
                    int[] possibilities = cave.getAllConnections(initialLoc);
                    bool notPrevious = true;                   
                    while (notPrevious) { //to ensure does not run into the room it came from
                        int nextRoom = r.Next(0, 6);
                        if (prevLoc != possibilities[nextRoom]) {
                            prevLoc = initialLoc;
                            finalLoc = possibilities[nextRoom];
                            initialLoc = finalLoc;
                            notPrevious = false;
                        }     
                    }
                }
            } else {
                int randomRoom = r.Next(0, 6);
                int[] connections = cave.getAllConnections(initialLoc);
                finalLoc = connections[randomRoom];
            }
            return finalLoc;
        }

        private bool withinTwoRooms() { //returns if wumpus is 2 rooms away from player
            int[] currentConnections = cave.getAllConnections(map.getPlayerLocation());
            int[] wumpusConnections = cave.getAllConnections(map.getWumpusLocation());
            for (int i = 0; i < currentConnections.Length; i++) {
                if (currentConnections[i] == wumpusConnections[i]) {
                    return true;
                }
            }
            return false;
        }

        public void startGame() {
            graphics.startGame();
            sound.playSound(Sound.Sounds.BackgroundMusic);
        }
    }
}