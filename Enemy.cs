using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_game
{
    internal class Enemy
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int ExperienceValue { get; private set; }

        public Enemy(string name, int health, int attack, int defense, int experienceValue)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            ExperienceValue = experienceValue;
        }

        public void AttackPlayer(Character player)
        {
            int damage = Attack - player.Defense;
            if (damage > 0)
            {
                player.Health -= damage;
                Console.WriteLine($"{Name} attacks {player.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name} attacks {player.Name}, but it's ineffective!");
            }
        }
    }
}
