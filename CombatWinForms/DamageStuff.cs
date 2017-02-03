using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatWinForms
{

//-------------------------------Change Neeeded----------------------------------------------------------------------------
//
// These are the only interfaces that I need for the moment.
//
//-------------------------------Change Neeeded----------------------------------------------------------------------------


    public interface IDamager
    {

        void Update();


        void TakeDamage(int damageTaken);

    }

    public interface IDamagable
    {

        void Update();

        void GiveDamage(int damageTaken);
    }










}
