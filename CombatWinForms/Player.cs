﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatWinForms
{

    //-------------------------------Change Neeeded----------------------------------------------------------------------------
    //
    // This is just not finished.
    //
    //-------------------------------Change Neeeded----------------------------------------------------------------------------


    class Player : Entity
    {

        public Player() { }

        public Player(int hp, /*string name,*/ int at/*, bool live*/)
        {
            Health = hp;
            AttackPower = at;
        }


    }
}
