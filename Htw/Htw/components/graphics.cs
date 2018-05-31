using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wumpus.forms;
using System.Drawing;
//using System.Windows.Forms;

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

        public void update(int currentRoom)
        {
            mainGame.UpdateGraphics(currentRoom);
        }

        public void Show(String message)
         {
             System.Windows.Forms.MessageBox.Show(message);

         }
         
    }
}



