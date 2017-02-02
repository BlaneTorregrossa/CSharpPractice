using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class YellowLight : ITestInterface
    {

        //public void Update()
        //{

        //}

        public void ToRed()
        {
            // This leads to the next state.
            // Should be used when timer reaches 3.
        }

        public void ToYellow()
        {
            // Should not be used.
            // Have it displayed if this is used.
        }

        public void ToGreen()
        {
            // Should not be used.
            // Have it displayed if this is used.
        }

        public void ToEnd()
        {
            // Leads to this state if off button is pushed.
            // This is not dependent on timer.
        }

    }
}
