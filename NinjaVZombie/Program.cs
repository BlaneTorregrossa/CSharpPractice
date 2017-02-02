using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaVZombie
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninjas ninjaA = new Ninjas(30, "Ninja 1", 3, true);
            Ninjas ninjaB = new Ninjas(35, "Ninja 2", 5, true);
            Zombies zombieA = new Zombies(30, "Zombie 1", 6, true);
            Zombies zombieB = new Zombies(25, "Zombie 2", 10, true);


            ninjaA.Attack(zombieA);
            ninjaA.Attack(zombieB);
            ninjaB.Attack(zombieA);
            ninjaB.Attack(zombieB);
            zombieA.Attack(ninjaA);
            zombieA.Attack(ninjaB);
            zombieB.Attack(ninjaA);
            zombieB.Attack(ninjaB);


           // Console.Write("Turn: ");

        }
    }
}
