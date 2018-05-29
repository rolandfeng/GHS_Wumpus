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
        public Sound()
        {
            
        }
        private void playSoundFromFile(Stream resourceName)
        {
            //load the file
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourceName);
            player.Play();
          
           
            //rp.Open(new WaveReader(resourceName));
         
            //play the sound
        }
        public enum Sounds {ArrowImpact, ArrowMiss, BatCall, BatsInCave, MonsterDie, MonsterGrowl, MonsterRoar, MonsterWalk,
        NoError, PlayerDie, PlayerWalk, ScaryScream, ScarySound, TriviaRight, TriviaWrong, MainMenu, BackgroundMusic}

        public void playSound(Sounds sound)
        {
            switch (sound)
            {
                case Sounds.ArrowImpact:
                    playSoundFromFile(Properties.Resources.ArrowImpact);
                    break;
                case Sounds.ArrowMiss:
                    playSoundFromFile(Properties.Resources.ArrowMiss);
                    break;
                case Sounds.BatCall:
                    playSoundFromFile(Properties.Resources.BatCall);
                    break;
                case Sounds.BatsInCave:
                    playSoundFromFile(Properties.Resources.BatsInCave);
                    break;
                case Sounds.MonsterDie:
                    playSoundFromFile(Properties.Resources.MonsterDie);
                    break;
                case Sounds.MonsterGrowl:
                    playSoundFromFile(Properties.Resources.MonsterGrowl);
                    break;
                case Sounds.MonsterRoar:
                    playSoundFromFile(Properties.Resources.MonsterRoar);
                    break;
                case Sounds.MonsterWalk:
                    playSoundFromFile(Properties.Resources.MonsterWalk);
                    break;
                case Sounds.NoError:
                    playSoundFromFile(Properties.Resources.NoError);
                    break;
                case Sounds.PlayerDie:
                    playSoundFromFile(Properties.Resources.PlayerDie);
                    break;
                case Sounds.PlayerWalk:
                    playSoundFromFile(Properties.Resources.PlayerWalk);
                    break;
                case Sounds.ScaryScream:
                    playSoundFromFile(Properties.Resources.ScaryScream);
                    break;
                case Sounds.ScarySound:
                    playSoundFromFile(Properties.Resources.ScarySound);
                    break;
                case Sounds.TriviaRight:
                    playSoundFromFile(Properties.Resources.TriviaRight);
                    break;
                case Sounds.TriviaWrong:
                    playSoundFromFile(Properties.Resources.TriviaWrong);
                    break;
                case Sounds.MainMenu:
                    playSoundFromFile(Properties.Resources.MainMenu);
                    break;
                case Sounds.BackgroundMusic:
                    playSoundFromFile(Properties.Resources.TriviaWrong);
                    //change
                    break;
            }
        }
    }
}
