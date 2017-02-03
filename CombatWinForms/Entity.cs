using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatWinForms
{

    //-------------------------------Change Neeeded----------------------------------------------------------------------------
    //
    // Have this be what the Opponent and Player classes are inheriting from.
    // Only things that matter in the Entity function that is an argument are int hp and int at.
    //
    //-------------------------------Change Neeeded----------------------------------------------------------------------------



    class Entity : IDamager, IDamagable
    {
        //Default constructor
        public Entity() { }

        //Constructor for Entity that takes in an argument of type int named hp and am argument of type int named at.
        public Entity(int hp, /*string name,*/ int at /*bool live*/)
        {
            Health = hp;       
            AttackPower = at;
        }


        public virtual bool Attack(Entity target)
        {
            target.health -= attackPower;
            return true;
        }


        // Update function from interface of IDamager exclusivly
        void IDamager.Update()
        {
            
        }

        // Update function from interface of IDamagable exclusivly
        void IDamagable.Update()
        {

        }

        // TakeDamage function from interface IDamager
        public void TakeDamage(int damageTaken)
        {

        }

        // GiveDamage function from interface IDamage
        public void GiveDamage(int damageGiven)
        {

        }


        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }


        private int attackPower;
        public int AttackPower
        {
            get { return attackPower; }
            set { attackPower = value; }
        }


     

    

    }
}
