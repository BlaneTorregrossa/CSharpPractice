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

        void ToRed();

        void ToYellow();

        void ToGreen();

        //Chamges to this after off button is pushed.
        void ToEnd();



    }

    
    


}
