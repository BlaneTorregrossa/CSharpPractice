using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaVZombie
{
    class Zombies : Entity
    {

        public Zombies() { }


        public Zombies(int hp, string name, int at, bool live)
        {
            Health = hp;
            CharacterName = name;
            AttackPower = at;
            Alive = live;
        }


       

    }
}
