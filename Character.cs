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
        public int Level { get; internal set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Energy { get; set; }
        public List<string> Abilities { get; private set; }
        public List<string> StatusEffects { get; private set; }

        public Character(string name, string charClass)
        {
            Name = name;
            Class = charClass;
            Level = 1;
            Experience = 0;
            Health = 100;
            Attack = 10;
            Defense = 5;
            Energy = 100;
            Abilities = new List<string>();
            StatusEffects = new List<string>();

            InitializeClassAbilities();
        }
        private void InitializeClassAbilities()
        {
            switch (Class)
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
                case "Paladin":
                    Abilities.AddRange(new string[] { "Smite", "Heal", "Divine Shield" });
                    break;
                case "Necromancer":
                    Abilities.AddRange(new string[] { "Raise Skeleton", "Life Drain", "Dark Pact" });
                    break;
                case "Ranger":
                    Abilities.AddRange(new string[] { "Rapid Shot", "Entangle", "Arrow Rain" });
                    break;
                case "Bard":
                    Abilities.AddRange(new string[] { "Inspire", "Lullaby", "Sonic Boom" });
                    break;
                case "Monk":
                    Abilities.AddRange(new string[] { "Fist of Fury", "Meditation", "Chi Burst" });
                    break;
                case "Druid":
                    Abilities.AddRange(new string[] { "Shape Shift", "Nature's Grasp", "Wild Growth" });
                    break;
                case "Assassin":
                    Abilities.AddRange(new string[] { "Assassinate", "Vanish", "Poison Cloud" });
                    break;
                case "Sorcerer":
                    Abilities.AddRange(new string[] { "Chain Lightning", "Magic Missile", "Teleport" });
                    break;
                case "Knight":
                    Abilities.AddRange(new string[] { "Cleave", "Defensive Stance", "Charge" });
                    break;
                case "Alchemist":
                    Abilities.AddRange(new string[] { "Potion Throw", "Transmute", "Bomb" });
                    break;
                case "Beastmaster":
                    Abilities.AddRange(new string[] { "Summon Wolf", "Ferocity", "Call of the Wild" });
                    break;
                case "Shaman":
                    Abilities.AddRange(new string[] { "Lightning Bolt", "Totem of Strength", "Spirit Walk" });
                    break;
                case "Templar":
                    Abilities.AddRange(new string[] { "Holy Strike", "Sanctuary", "Judgment" });
                    break;
                case "Elementalist":
                    Abilities.AddRange(new string[] { "Flame Burst", "Water Surge", "Earthquake" });
                    break;
                case "Blood Knight":
                    Abilities.AddRange(new string[] { "Bloodthirst", "Sacrifice", "Crimson Blade" });
                    break;
                case "Chronomancer":
                    Abilities.AddRange(new string[] { "Time Warp", "Temporal Shield", "Hasten" });
                    break;
                case "Shadow Dancer":
                    Abilities.AddRange(new string[] { "Shadow Strike", "Phantom Step", "Cloak of Shadows" });
                    break;
            }
        }
    }
}