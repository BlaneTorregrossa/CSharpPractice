using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class LightPattern
    {

        //------------------------------------Needs Revision-----------------------------------------------------------
        public int LightTimer()
        {
            int currentGoal = 0;
            int currentTime = 0;
            int timerGoalA = 3;
            int timerGoalB = 7;
            int timerGoalC = 10;



            if(currentGoal <= 0)
            {
                currentGoal = timerGoalB;
            }

            
            while (currentTime != currentGoal)
            {
                //Take input for time
            }


            // Don't think this is nessesary or it needs to be modified
            if (currentTime >= currentGoal)
            {
                if (currentGoal != timerGoalA && currentGoal != timerGoalC)
                {
                    currentGoal = timerGoalC;
                    currentTime = 0;
                }

                else if (currentGoal != timerGoalB && currentGoal != timerGoalA)
                {
                    currentGoal = timerGoalA;
                    currentTime = 0;
                }

                else if (currentGoal != timerGoalC && currentGoal != timerGoalB)
                {
                    currentGoal = timerGoalA;
                    currentTime = 0;
                }
            }

            return currentTime;
        }


     


    }
}
