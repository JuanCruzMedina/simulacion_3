using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP_3
{
    public class Common
    {
        public static double TruncateDouble(double d, int decimals)
        {
            if (decimals < 0)
                throw new ArgumentOutOfRangeException("doubles", "Value must be in range 0-28.");
            else if (decimals > 15)
                throw new ArgumentOutOfRangeException("doubles", "Value must be in range 0-28.");
            else if (decimals == 0)
                return Math.Truncate(d);
            else
            {
                double integerPart = Math.Truncate(d);
                double scalingFactor = d - integerPart;
                double multiplier = (double)Math.Pow(10, decimals);

                scalingFactor = Math.Truncate(scalingFactor * multiplier) / multiplier;

                return integerPart + scalingFactor;
            }
        }
    }
}
