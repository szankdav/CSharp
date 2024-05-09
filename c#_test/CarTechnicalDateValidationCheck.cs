using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test
{
    public static class CarTechnicalDateValidationCheck
    {
        public static bool IsCarTechnicalValidationExpired(Car car)
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

        public static bool IsCarTechnicalValidationExpireLessThanThirtyDays(Car car)
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
