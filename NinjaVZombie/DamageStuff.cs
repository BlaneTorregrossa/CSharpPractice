using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaVZombie
{

    public interface IDamagable
    {
        void TakeDamage(int damageTaken);
    }

    public interface IDamager
    {
        void GiveDamage(int damageGiven);
    }

    class DamageStuff : IDamagable, IDamager
    {

        //void IDamagable.TakeDamage(int damageTaken)
        //{
            
        //}

        //void IDamager.GiveDamage(int damageGiven)
        //{

        //}

        static void main()
        {
            IDamagable Tdmg = new DamageStuff();
            IDamager Gdmg = new DamageStuff();


            Tdmg.TakeDamage(1);
            Gdmg.GiveDamage(1);
        }


        //Suggested by visusal
        public void GiveDamage(int damageGiven)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damageTaken)
        {
            throw new NotImplementedException();
        }
    }
}
