using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test
{
    public static class CarInsuranceDateValidationCheck
    {
        public static bool IsCarInsuranceValidationExpired(Car car)
        {
            if (car.TechnicalValidty > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCarInsuranceValidationExpireLessThanThirtyDays(Car car)
        {
            if (car.TechnicalValidty.Day - DateTime.Now.Day < 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
