using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideApp
{
    public class DivideCalculate
    {
        public double Divide(double divident, double divider)
        {
            if (divider == 0 )
            {
                throw new DivideByZeroException("0-val nem osztunk!");
            }

            return divident / divider;
        }
    }
}
