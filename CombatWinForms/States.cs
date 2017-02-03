using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatWinForms
{

    //-------------------------------Change Neeeded----------------------------------------------------------------------------
    //
    // This needs to work with the FSM Class and be able to Work the FSM correctly
    // Restart with this and the FSM class this Weekend.
    // Don't Work on anything else until this works properly!
    //
    //-------------------------------Change Neeeded----------------------------------------------------------------------------


    enum TurnOrder
    {
        INIT = 0,
        SWITCHCHARACTER = 1,
        ATTACK = 2,
        ENDTURN = 3,
        END = 100,
    }




    class States
    {
        public States() { }


        public delegate void OnEnter();
        public OnEnter onEnter;


        public delegate void OnExit();
        public OnExit onExit;


        //public void CurrentState()
        //{

        //}

        public void AddEnterFunction(Delegate x)
        {
            
        }

        public void AddExitFunction(Delegate y)
        {

        }
    }
}
