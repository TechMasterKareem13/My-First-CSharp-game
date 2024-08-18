using CSharp_game;
using System;

namespace CSharp_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Realm of Shadows!");

            Console.Write("Enter your character's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Choose your class:");
            DisplayClassOptions();
            Console.Write("Enter the number of your class: ");
            string classChoice = Console.ReadLine();
            string charClass = GetClassFromChoice(classChoice);

            Character player = new Character(name, charClass);

            Console.WriteLine($"Welcome, {player.Name} the {player.Class}!");
            Console.WriteLine($"Your adventure begins now, {player.Name}!");

            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Explore");
                Console.WriteLine("2. View Character");
                Console.WriteLine("3. View Inventory");
                Console.WriteLine("4. Save Game");
                Console.WriteLine("5. Exit Game");
                Console.Write("Choose an action: ");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Explore(player);
                        break;
                    case "2":
                        ViewCharacter(player);
                        break;
                    case "3":
                        ViewInventory(player);
                        break;
                    case "4":
                        SaveGame(player);
                        break;
                    case "5":
                        gameOver = true;
                        Console.WriteLine("Thank you for playing my first C# Game");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void DisplayClassOptions()
        {
            string[] classes = new string[]
            {
                "1. Warrior", "2. Mage", "3. Rogue", "4. Paladin", "5. Necromancer",
                "6. Ranger", "7. Bard", "8. Monk", "9. Druid", "10. Assassin",
                "11. Sorcerer", "12. Knight", "13. Alchemist", "14. Beastmaster",
                "15. Shaman", "16. Templar", "17. Elementalist", "18. Blood Knight",
                "19. Chronomancer", "20. Shadow Dancer"
            };

            foreach (string classOption in classes)
            {
                Console.WriteLine(classOption);
            }
        }

        static string GetClassFromChoice(string choice)
        {
            return choice switch
            {
                "1" => "Warrior",
                "2" => "Mage",
                "3" => "Rogue",
                "4" => "Paladin",
                "5" => "Necromancer",
                "6" => "Ranger",
                "7" => "Bard",
                "8" => "Monk",
                "9" => "Druid",
                "10" => "Assassin",
                "11" => "Sorcerer",
                "12" => "Knight",
                "13" => "Alchemist",
                "14" => "Beastmaster",
                "15" => "Shaman",
                "16" => "Templar",
                "17" => "Elementalist",
                "18" => "Blood Knight",
                "19" => "Chronomancer",
                "20" => "Shadow Dancer",
                _ => "Warrior",
            };
        }

        static void Explore(Character player)
        {
            Console.WriteLine("You venture into the unknown...");

            Random rand = new Random();
            int eventRoll = rand.Next(1, 4);

            if (eventRoll == 1)
            {
                Enemy enemy = EnemyFactory.CreateRandomEnemy();
                Combat.StartCombat(player, enemy);
            }
            else if (eventRoll == 2)
            {
                Console.WriteLine("You found a hidden treasure chest!");
                Console.WriteLine("You found a health potion.");
            }
            else
            {
                Console.WriteLine("You explore the area, but find nothing of interest.");
            }
        }

        static void ViewCharacter(Character player)
        {
            Console.WriteLine("\nCharacter Details:");
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Class: {player.Class}");
            Console.WriteLine($"Level: {player.Level}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Attack: {player.Attack}");
            Console.WriteLine($"Defense: {player.Defense}");
            Console.WriteLine($"Experience: {player.Experience}/100");
            Console.WriteLine("Abilities: " + string.Join(", ", player.Abilities));
        }

        static void ViewInventory(Character player)
        {
            Console.WriteLine("\nInventory:");
            Console.WriteLine("Health Potion x1");
            Console.WriteLine("Iron Sword (equipped)");
        }

        static void SaveGame(Character player)
        {
            Console.WriteLine("Saving game...");
            Console.WriteLine("Game saved successfully.");
        }
    }
}
