using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_game
{
    internal class Character
    {
        public string Name { get; private set; }
        public string Class { get; private set; }
        public int Level { get; private set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Abilities { get; private set; }

        public Character(string name, string charClass)
        {
            Name = name;
            Class = charClass;
            Level = 1;
            Experience = 0;
            Health = 100;
            Attack = 10;
            Defense = 5;
            Abilities = new List<string>();

            switch (charClass)
            {
                case "Warrior":
                    Abilities.AddRange(new string[] { "Slash", "Shield Bash", "Berserk" });
                    break;
                case "Mage":
                    Abilities.AddRange(new string[] { "Fireball", "Ice Spike", "Arcane Blast" });
                    break;
                case "Rogue":
                    Abilities.AddRange(new string[] { "Backstab", "Poison Dagger", "Shadow Step" });
                    break;
            }
        }

        public void LevelUp()
        {
            Level++;
            Experience = 0;
            Health += 20;
            Attack += 5;
            Defense += 3;
            Console.WriteLine($"{Name} leveled up! Now at level {Level}.");
        }
    }
}
