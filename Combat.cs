using CSharp_game;
using System;

public static class Combat
{
    internal static void StartCombat(Character player, Enemy enemy)
    {
        Console.WriteLine($"\nA wild {enemy.Name} appears!");

        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("\nChoose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Ability");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Flee");

            string action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    Attack(player, enemy);
                    break;
                case "2":
                    UseAbility(player, enemy);
                    break;
                case "3":
                    Defend(player);
                    break;
                case "4":
                    Console.WriteLine("You fled from the battle!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }

            if (enemy.Health > 0)
            {
                enemy.UseAbility(player);
            }
        }

        if (player.Health <= 0)
        {
            Console.WriteLine("You have been defeated...");
            return;
        }

        Console.WriteLine($"You defeated the {enemy.Name}!");
        player.Experience += enemy.ExperienceValue;
        Console.WriteLine($"You gained {enemy.ExperienceValue} experience points.");

        if (player.Experience >= 100)
        {
            LevelUp(player);
        }
    }

    private static void Attack(Character player, Enemy enemy)
    {
        int damage = player.Attack - enemy.Defense;
        damage = damage > 0 ? damage : 1;
        enemy.Health -= damage;
        Console.WriteLine($"You deal {damage} damage to the {enemy.Name}. It has {enemy.Health} health left.");
    }

    private static void UseAbility(Character player, Enemy enemy)
    {
        Console.WriteLine("Choose an ability:");
        for (int i = 0; i < player.Abilities.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {player.Abilities[i]}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= player.Abilities.Count)
        {
            Console.WriteLine("Invalid choice, try again.");
            return;
        }

        string ability = player.Abilities[choice];
        Console.WriteLine($"You use {ability}!");

        switch (ability)
        {
            case "Slash":
                enemy.Health -= 15;
                Console.WriteLine($"{enemy.Name} takes 15 damage!");
                break;
            case "Fireball":
                enemy.Health -= 20;
                Console.WriteLine($"{enemy.Name} takes 20 fire damage!");
                break;
        }

        player.Energy -= 10; 
    }

    private static void Defend(Character player)
    {
        Console.WriteLine("You brace yourself for the next attack, reducing damage taken by half.");
        player.Defense *= 2;
    }

    private static void LevelUp(Character player)
    {
        player.Level++;
        player.Health += 20;
        player.Attack += 5;
        player.Defense += 5;
        player.Energy += 10;
        player.Experience = 0;
        Console.WriteLine($"Congratulations! You have reached level {player.Level}.");
    }
}
