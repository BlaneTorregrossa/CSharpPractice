using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class GreenLight : ITestInterface
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
            // This leads to next state.
            // Should be used when timer reaches 7
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
