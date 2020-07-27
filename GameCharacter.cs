using System;
using System.Collections.Generic;
using System.Text;

namespace RPGLab
{
    class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter(string charName, int str, int smarts)
        {
            Name = charName;
            Strength = str;
            Intelligence = smarts;
        }

        public virtual void Play()
        {
            Console.Write($"\n{Name} int {Intelligence}, strength {Strength}");
        }

    }
}
