using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaVZombie
{
    class Entity : DamageStuff /*: Damager, Damagable*/ 
    {

        public Entity() { }


        public Entity(int hp, string name, int at, bool live)
        {
            Health = hp;
            CharacterName = name;
            AttackPower = at;
            Alive = live;
        }
        

        public virtual bool Attack(Entity target)
        {
            target.health -= attackPower + 5;
            return true;
        }


        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }


        private string characterName;
        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }


        private int attackPower;
        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }


        private bool alive;
        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }
    }
}
