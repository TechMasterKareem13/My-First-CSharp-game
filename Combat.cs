using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_game
{
    internal class Combat
    {
        public static void StartCombat(Character player, Enemy enemy)
        {
            Console.WriteLine($"A wild {enemy.Name} appears!");

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("\nChoose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use Ability");
                Console.WriteLine("3. Use Item");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Attack(player, enemy);
                        break;
                    case "2":
                        UseAbility(player, enemy);
                        break;
                    case "3":
                        UseItem(player);
                        break;
                    default:
                        Console.WriteLine("Invalid action. Try again.");
                        break;
                }

                if (enemy.Health > 0)
                {
                    enemy.AttackPlayer(player);
                }
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("You have been defeated!");
            }
            else
            {
                Console.WriteLine($"You defeated the {enemy.Name}!");
                player.Experience += enemy.ExperienceValue;
                if (player.Experience >= 100)
                {
                    player.LevelUp();
                }
            }
        }

        private static void Attack(Character player, Enemy enemy)
        {
            int damage = player.Attack - enemy.Defense;
            if (damage > 0)
            {
                enemy.Health -= damage;
                Console.WriteLine($"{player.Name} attacks {enemy.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{player.Name} attacks {enemy.Name}, but it's ineffective!");
            }
        }

        private static void UseAbility(Character player, Enemy enemy)
        {
            Console.WriteLine("Choose an ability:");
            for (int i = 0; i < player.Abilities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {player.Abilities[i]}");
            }
            int choice = int.Parse(Console.ReadLine()) - 1;
            string ability = player.Abilities[choice];

            switch (player.Class)
            {
                case "Warrior":
                    WarriorSkills(player, enemy, ability);
                    break;
                case "Mage":
                    MageSkills(player, enemy, ability);
                    break;
                case "Rogue":
                    RogueSkills(player, enemy, ability);
                    break;
            }
        }

        private static void WarriorSkills(Character player, Enemy enemy, string ability)
        {
            switch (ability)
            {
                case "Slash":
                    Console.WriteLine($"{player.Name} slashes the {enemy.Name}!");
                    enemy.Health -= player.Attack;
                    break;
                case "Shield Bash":
                    Console.WriteLine($"{player.Name} bashes the {enemy.Name} with a shield!");
                    enemy.Health -= player.Attack / 2;
                    // Implement stun logic
                    break;
                case "Berserk":
                    Console.WriteLine($"{player.Name} goes berserk!");
                    player.Attack += 5;
                    break;
            }
        }

        private static void MageSkills(Character player, Enemy enemy, string ability)
        {
            switch (ability)
            {
                case "Fireball":
                    Console.WriteLine($"{player.Name} hurls a fireball at the {enemy.Name}!");
                    enemy.Health -= player.Attack + 10;
                    break;
                case "Ice Spike":
                    Console.WriteLine($"{player.Name} launches an ice spike at the {enemy.Name}!");
                    enemy.Health -= player.Attack + 5;
                    // Implement freeze logic
                    break;
                case "Arcane Blast":
                    Console.WriteLine($"{player.Name} unleashes an arcane blast!");
                    enemy.Health -= player.Attack + 15;
                    break;
            }
        }

        private static void RogueSkills(Character player, Enemy enemy, string ability)
        {
            switch (ability)
            {
                case "Backstab":
                    Console.WriteLine($"{player.Name} backstabs the {enemy.Name}!");
                    enemy.Health -= player.Attack * 2;
                    break;
                case "Poison Dagger":
                    Console.WriteLine($"{player.Name} poisons the {enemy.Name}!");
                    enemy.Health -= player.Attack;
                    // Implement poison over time logic
                    break;
                case "Shadow Step":
                    Console.WriteLine($"{player.Name} uses Shadow Step!");
                    player.Defense += 5;
                    break;
            }
        }

        private static void UseItem(Character player)
        {
            Console.WriteLine("You used a health potion.");
            player.Health += 20;
            if (player.Health > 100) player.Health = 100;
            Console.WriteLine($"Your health is now {player.Health}.");
        }
    }
}
