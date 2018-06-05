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

        public event EventHandler GameClosing;

        public GameControl() {
            cave = new Cave("../../Resource/StandardCave.txt");
            map = new Map();
            sound = new Sound();
            trivia = new Trivia(this);
            form = new InputForm();
            highscores = new ScoreManager();
            player = new Player();
            graphics = new Graphics(this, player, map, cave);
        }

        public void closeGame()
        {
            GameClosing.Invoke(this, null);
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
            //sound.playSound(Sound.Sounds.BackgroundMusic);
            if (map.pitFall()) {
                pitInstance();
            }
            if (map.batCheck()){
                graphics.update(map.getPlayerLocation());
                hazardWarnings(getHazardArray(map.getPlayerLocation()));
            }
            if (newLoc == map.getWumpusLocation()) {
                openTrivia(5, 3, 1);
                map.changeWumpusLocation(wumpusFleeLoc(true));
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
                highscores.LoadHighScores();
                form.Show();
                form.FormHiding += (send, args) =>
                {
                    highscores.StoreHighScore(form.getName(), playerScore);
                    highscores.DisplayHighScores();
                };           
                //end game --- option to play again?
            } else {
                sound.playSound(Sound.Sounds.ArrowMiss);
                if (cave.isAdjacent(map.getPlayerLocation(), map.getWumpusLocation())) {
                    graphics.Show("You missed but alerted the Wumpus! The Wumpus has moved to a new planet!");
                } else {
                    graphics.Show("You missed!");
                }
                if (player.getArrowCount() == 0) {
                    graphics.Show("You ran out of arrows!");
                    sound.playSound(Sound.Sounds.PlayerDie);
                    //end game
                }
                map.changeWumpusLocation(wumpusFleeLoc(false));
            }
        }

        public void buyArrows() {
            //openTrivia(3, 2, 3);
            map.changeWumpusLocation(7);
        }

        public void openTrivia(int asked, int needed, int type) {
            if (player.getCoinCount() < 2) {
                sound.playSound(Sound.Sounds.NoError);
                graphics.Show("Not enough coins for trivia!");
            } else {
                player.changeCoinCount(-2);
                graphics.updateCoins();
                trivia.ShowTrivia();
                trivia.ask(asked, needed, type);
            }
        }

        public void buySecret() {
            openTrivia(3, 2, 4);
        }
        public string produceSecret() {
            Random r = new Random();
            int whichHint = r.Next(0, 8); //(0, n) = range from 0 to n-1
            if (whichHint == 0 || whichHint == 1) { //bat rooms
                int[] bats = map.getBatLocations();
                return ("There is a UFO in planet " + bats[whichHint] + "!");
            }
            else if (whichHint == 2 || whichHint == 3) { //pit rooms
                int[] pits = map.getPitLocations();
                return ("There is a black hole in planet " + pits[whichHint - 2] + "!");
            }
            else if (whichHint == 4) { //Wumpus location
                return ("The Wumpus is in planet " + map.getWumpusLocation() + "!");
            }
            else if (whichHint == 5) { //bogus hint
                return ("You are in planet " + map.getPlayerLocation() + "!");
            }
            else if (whichHint == 6) {//Wumpus is 2 rooms away or not
                if (withinTwoRooms())
                    return ("The Wumpus is 1 or 2 planets away!");
                else
                    return ("The Wumpus is further than 2 planets away!");
            }
            else { //more troll hints, can add more
                return ("It is turn " + player.getTurn() + "!");
            }
        }
        public void pitInstance() {
            openTrivia(3, 2, 2);
        }

        public void displayHighscores() {
            highscores.StoreHighScore("bokchewy", 234);
            highscores.DisplayHighScores();
        }

        private bool[] getHazardArray(int newLoc) { //create array of booleans for each obstacle, if near or same room
            bool[] hazards = new bool[6];
            int wumpusLoc = map.getWumpusLocation();
            if (newLoc == wumpusLoc) {
                hazards[0] = true;
            } else if (cave.isAdjacent(newLoc, wumpusLoc)) {
                hazards[1] = true;
            }
            int[] batsLoc = map.getBatLocations();
            int[] pitsLoc = map.getPitLocations();
            if (newLoc == batsLoc[0] || newLoc == batsLoc[1]) {
                hazards[2] = true;
            } else if (newLoc == pitsLoc[0] || newLoc == pitsLoc[1]) {
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
                sound.playSound(Sound.Sounds.MonsterRoar);
                graphics.Show("You found the Wumpus! Answer 3 of 5 trivia questions correctly to escape!");
            }
            if (hazards[1]) {//adjacent to wumpus
                sound.playSound(Sound.Sounds.MonsterGrowl);
                graphics.Show("You smell a Wumpus!");
            }
            if (hazards[2]) {//same room as bats
                sound.playSound(Sound.Sounds.BatsInCave);
                graphics.Show("You were teleported to a random planet by a UFO!");
            }
            if (hazards[3]) {//adjacent to bats
                sound.playSound(Sound.Sounds.BatCall);
                graphics.Show("You sense a UFO is nearby...");
            }
            if (hazards[4]) {//same room as pits 
                sound.playSound(Sound.Sounds.ScaryScream);
                graphics.Show("You've been sucked into a black hole! Answer 2 of 3 trivia questions correctly to escape!");
            }
            if (hazards[5]) {//adjacent to pits
                sound.playSound(Sound.Sounds.ScarySound);
                graphics.Show("You can feel a black hole nearby...");
            }
        }

        private int wumpusFleeLoc(bool multiple) { 
            Random r = new Random();
            int prevLoc = 0;
            int initialLoc = map.getWumpusLocation();
            int finalLoc = -1; //only temporary
            if (multiple) { //wumpus runs 2-4 rooms away
                int howMany = r.Next(2, 5);
                for (int i = 0; i < howMany; i++) { 
                    int[] possibilities = cave.getAllConnections(initialLoc);
                    bool notPrevious = true;                   
                    while (notPrevious) { //to ensure does not run into the room it came from
                        int nextRoom = r.Next(0, 6);
                        if (prevLoc != possibilities[nextRoom] && possibilities[nextRoom] != 0) {
                            prevLoc = initialLoc;
                            finalLoc = possibilities[nextRoom];
                            initialLoc = finalLoc;
                            notPrevious = false;
                        }     
                    }
                }
            } else {
                int[] connections = cave.getAllConnections(initialLoc);
                do {
                    finalLoc = connections[r.Next(0, 6)];
                } while (finalLoc == 0);
            }
            return finalLoc;
        }

        private bool withinTwoRooms() { //returns if wumpus is 1 or 2 rooms away from player
            int[] currentConnections = cave.getAllConnections(map.getPlayerLocation());
            int[] wumpusConnections = cave.getAllConnections(map.getWumpusLocation());
            for (int i = 0; i < currentConnections.Length; i++) {//outer loop
                for (int j = 0; j < wumpusConnections.Length; j++) {//nested for loop to traverse through arrays
                    if (currentConnections[i] == wumpusConnections[j] && currentConnections[i] != 0) {
                        return true;
                    }
                }

            }
            return false;
        }

        public void doneWithTrivia(bool succeed, int type) {
            if (type == 1 || type == 2) {//wumpus or pit
                if (!succeed) {
                    sound.playSound(Sound.Sounds.TriviaWrong);
                    sound.playSound(Sound.Sounds.PlayerDie);
                    graphics.Show("Oh dear, you are dead!");
                    //endgame
                } else {
                    sound.playSound(Sound.Sounds.TriviaRight);
                    graphics.Show("You survived!");
                }
            } else if (type == 3) {//arrows
                if (succeed) {
                    player.changeArrowCount(2);
                    sound.playSound(Sound.Sounds.TriviaRight);
                    graphics.Show("Well done!");
                } else {
                    sound.playSound(Sound.Sounds.TriviaWrong);
                    graphics.Show("Better luck next time!");
                }
                graphics.updateArrows();
            } else if (type == 4) {//secret
                if (succeed) {
                    sound.playSound(Sound.Sounds.TriviaRight);
                    graphics.Show(produceSecret());
                } else {
                    sound.playSound(Sound.Sounds.TriviaWrong);
                    graphics.Show("Better luck next time!");
                }
            }
        }

        public void startGame() {
            graphics.startGame();
            graphics.update(1);
            hazardWarnings(getHazardArray(1));
            sound.playSound(Sound.Sounds.BackgroundMusic);
        }
    }
}