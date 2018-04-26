using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components
{

    public class Sound
    {
        private void playSoundFromFile(Stream resourceName)
        {
            //load the file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourceName);
            player.Play();
          
           
            //rp.Open(new WaveReader(resourceName));
         
            //play the sound
        }
        public enum Sounds {DoorOpen}

        public void playSound(Sounds sound)
        {
            switch (sound)
            {
                case Sounds.DoorOpen:
                    playSoundFromFile(Properties.Resources.creakingdoor);
                    break;
            }
        }
    }
}