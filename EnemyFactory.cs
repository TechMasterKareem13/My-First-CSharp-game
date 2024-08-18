using System;
using System.Collections.Generic;

public static class EnemyFactory
{
    private static readonly List<Enemy> Enemies = new List<Enemy>
    {
        new Enemy("Goblin", 50, 10, 5, 20, new List<string> { "Slash", "Quick Jab" }),
        new Enemy("Orc", 100, 20, 10, 40, new List<string> { "Heavy Smash", "Roar" }),
        new Enemy("Troll", 150, 15, 20, 50, new List<string> { "Regenerate", "Club Swing" }),
        new Enemy("Lich", 80, 25, 10, 60, new List<string> { "Dark Bolt", "Summon Undead" }),
        new Enemy("Dragon", 200, 30, 25, 100, new List<string> { "Fire Breath", "Tail Swipe" }),
        new Enemy("Vampire", 90, 18, 12, 50, new List<string> { "Life Drain", "Bat Swarm" }),
        new Enemy("Giant Spider", 70, 12, 8, 30, new List<string> { "Poison Bite", "Web Trap" }),
        new Enemy("Ghost", 60, 15, 5, 40, new List<string> { "Ethereal Form", "Haunt" }),
        new Enemy("Golem", 180, 20, 30, 70, new List<string> { "Earth Slam", "Rock Throw" }),
        new Enemy("Hydra", 160, 25, 20, 80, new List<string> { "Multi-Head Strike", "Regenerate Heads" }),
    };

    public static Enemy CreateRandomEnemy()
    {
        Random rand = new Random();
        return Enemies[rand.Next(Enemies.Count)];
    }
}
