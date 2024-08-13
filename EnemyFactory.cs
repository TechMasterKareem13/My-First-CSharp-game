using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_game
{
    internal class EnemyFactory
    {
        public static Enemy CreateRandomEnemy()
        {
            Random rand = new Random();
            int enemyType = rand.Next(1, 5); //numbers of enemies i want to add(incase i forget)

            return enemyType switch
            {
                1 => new Enemy("Goblin", 50, 5, 2, 20),
                2 => new Enemy("Orc", 70, 7, 3, 30),
                3 => new Enemy("Troll", 100, 10, 5, 50),
                4 => new Enemy("Rat", 20, 3, 1, 10),
                _ => new Enemy("Goblin", 50, 5, 2, 20),
            };
        }
    }
}
