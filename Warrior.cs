using System;
using System.Collections.Generic;
using System.Text;

namespace RPGLab
{
    class Warrior : GameCharacter
    {
        public string WeaponType { set; get; }

        public Warrior(string charName, int str, int smarts, string weapon) : base(charName, str, smarts)
        {
            WeaponType = weapon;
        }

        public override void Play()
        {
            base.Play();
            Console.Write($", Weapon: {WeaponType}");
        }

    }
}
