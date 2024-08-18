using CSharp_game;
using System.Collections.Generic;

public class Enemy
{
    public string Name { get; private set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int ExperienceValue { get; private set; }
    public List<string> Abilities { get; private set; }

    public Enemy(string name, int health, int attack, int defense, int experienceValue, List<string> abilities)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defense = defense;
        ExperienceValue = experienceValue;
        Abilities = abilities;
    }

    internal void UseAbility(Character player)
    {
        string ability = Abilities[new Random().Next(Abilities.Count)];
        Console.WriteLine($"{Name} uses {ability}!");

        switch (ability)
        {
            case "Fire Breath":
                player.Health -= 15;
                Console.WriteLine($"{player.Name} takes 15 fire damage!");
                break;
            case "Poison Bite":
                player.Health -= 10;
                player.StatusEffects.Add("Poisoned");
                Console.WriteLine($"{player.Name} is poisoned!");
                break;
            case "Shadow Strike":
                player.Health -= 20;
                Console.WriteLine($"{player.Name} takes 20 shadow damage!");
                break;
        }
    }
}
