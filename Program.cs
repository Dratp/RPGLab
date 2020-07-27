using System;
using System.Collections.Generic;

namespace RPGLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> Party = new List<GameCharacter>();
            
            Party.Add(new Warrior("Adam the viking", 16, 4, "Battle Axe"));
            Party.Add(new Warrior("Zach the noble Knight", 14,6, "Excalibur"));
            Party.Add(new Wizard("Chuck the visionary", 3, 17, 12, 7));
            Party.Add(new Wizard("Brendan the sorcerer", 4, 16, 16, 4));
            Party.Add(new Wizard("Dave the wizened", 3, 17, 10, 10));
            Party.Add(new Warrior("David the squire", 8, 4, "Stick"));

            foreach(GameCharacter member in Party)
            {
                member.Play();
            }
        }
    }
}
