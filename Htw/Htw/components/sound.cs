using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{

    class Sound
    {
        private void playSoundFromFile(String fileName)
        {
            //load the file
            //play the sound
        }
        public enum Sounds { DoorOpen }

        public void playSound(Sounds sound)
        {
            switch (sound)
            {
                case Sounds.DoorOpen:
                    playSoundFromFile("SqueekingDoor.mp3");
                    break;
            }
        }
    }
}