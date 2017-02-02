using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{

    public interface ITestInterface
    {

//----------------------------------Needs Revision-----------------------------------------
        //void Update();

        // Changes to this after timer reaches 3
        void ToRed();

        // Changes to this after timer reaches 7
        void ToYellow();

        //Changes to this after timer reaches 10
        void ToGreen();

        //Chamges to this after off button is pushed.
        void ToEnd();


    }


}
