using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skib3
{
    class B
    {
        public B()
        {
            // Default konstruktør uden input
        }

        public double ConvertKmPerHourToKnots(double kmITimen)
        {
            double knobs = kmITimen * 0.53996;
            return knobs;
        }

        public double ConvertKnotsToKmPerHour(double knobs)
        {
            double kmITimen = knobs / 0.53996;
            return kmITimen;
        }
    }
}
