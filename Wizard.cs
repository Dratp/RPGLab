using System;
using System.Collections.Generic;
using System.Text;

namespace RPGLab
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(string charName, int str, int smarts, int energy, int numofSpells) : base(charName, str, smarts, energy)
        {
            SpellNumber = numofSpells;
        }

        public override void Play()
        {
            base.Play();
            Console.Write($", {SpellNumber} spells");
        }

    }
}
