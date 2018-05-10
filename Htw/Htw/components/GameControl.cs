﻿using System;
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
            int currentLoc = player.getCurrentLocation();
            int newLoc = cave.getConnectedRoom(currentLoc, direction);
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
            player.changePlayerLocation(newLoc, hazards);
        }

        public void shootArrows() {
        
        }

        public void startGame()
        {
            graphics.startGame();
        }
    }
}