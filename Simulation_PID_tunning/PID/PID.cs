using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_PID_tunning.PID
{
    class PID
    {
        public double Kd { get; set; }
        public double Ki { get; set; }
        public double Kp { get; set; }

        public double MinOutput { get; set; }
        public double MaxOutput { get; set; }
        public double Integrated { get; set; }
        public double PrevInput { get; set; }
        public bool FirstTime { get; set; }

        public PID()
        {
            Integrated = 0;
            PrevInput = 0;
            FirstTime = true;
        }

        public void Reset()
        {
            Integrated = 0;
            PrevInput = 0;
            FirstTime = true;
        }

        public double Calculate(double desiredSetPoint, double actualValue)
        {
            var error = 0.0;
            var result = 0.0;

            //todo use the FirstTime property. There is a condition on this variable.
            
            error = desiredSetPoint - actualValue; //actual error

                          //prop                 //derivative         //integral
            result = (error * Kp) + ((error - PrevInput) * Kd) + Integrated * Ki;

            PrevInput = error;
            Integrated = Integrated + error; //calculated integrated value
            

            if (result > MaxOutput)
            {
                result = MaxOutput;
            }
            else if (result < MinOutput)
            {
                result = MinOutput;
            }

            return result;
        }
    }
}
