using System;
using System.Collections.Generic;
using System.Text;

namespace RPGLab
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnerygy { set; get; }

        public MagicUsingCharacter(string charName, int str, int smarts, int energy) : base(charName, str, smarts)
        {
            MagicalEnerygy = energy;
        }

        public override void Play()
        {
            base.Play();
            Console.Write($", magic {MagicalEnerygy}");
        }

    }
}
