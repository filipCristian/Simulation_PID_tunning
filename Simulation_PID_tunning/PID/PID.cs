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
           
        }
    }
}
