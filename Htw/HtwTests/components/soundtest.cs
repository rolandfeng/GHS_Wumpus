using Microsoft.VisualStudio.TestTools.UnitTesting;
using wumpus.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumpus.components.Tests
{
    [TestClass()]
    public class SoundTests
    {
        [TestMethod()]
        public void PlaySound()
        {
            Sound example = new Sound();
            example.playSound(Sound.Sounds.ArrowImpact);
        }
    }
}