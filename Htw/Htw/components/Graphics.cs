using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.forms;

namespace wumpus.components
{
    public class Graphics
    {
        GameControl gameControl;
        Player player;
        Map map;
        Cave cave;
        MainGame mainGame;


        public Graphics(GameControl gameControl, Player player, Map map, Cave cave)
        {
            this.gameControl = gameControl;
            this.player = player;
            this.map = map;
            this.cave = cave;
        }

        public void startGame()
        {
            mainGame = new MainGame(gameControl, player, map, cave);
            mainGame.Show();
        }

        public void update(int currentRoom, bool[] hazards)
        {
            mainGame.UpdateGraphics(currentRoom, hazards);
        }


    }
}
