using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class RedLight : ITestInterface
    {

        //public void Update()
        //{

        //}

        public void ToRed()
        {
            // Should not be used.
            // Have it displayed if this is used.
        }

        public void ToYellow()
        {
            // Should not be used.
            // Have it displayed if this is used.
        }

        public void ToGreen()
        {
            // Leads to the next state.
            // Should be used when timer has reached 10
        }

        public void ToEnd()
        {
            // Leads to this state if off button is pushed.
            // This is not dependent on timer.
        }



    }
}
