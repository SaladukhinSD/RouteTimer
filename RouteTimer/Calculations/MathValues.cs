using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteTimer
{
    internal class MathValues
    {
        internal static int calculate(int dataMinutes, int dataDistance)
        {
            double speedInHours = dataMinutes / 60.0;
            double speed = dataDistance / 1000 / speedInHours;
            return (Convert.ToInt32(speed));
        }
    }
}
