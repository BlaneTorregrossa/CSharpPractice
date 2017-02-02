using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaVZombie
{
    class Ninjas : Entity
    {

        public Ninjas() { }


        public Ninjas(int hp, string name, int at, bool live)
        {
            Health = hp;
            CharacterName = name;
            AttackPower = at;
            Alive = live;
        }

        

    }
}
