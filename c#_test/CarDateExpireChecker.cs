using csharp_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test
{
    public static class CarDateExpireChecker
    {
        public static string ExpiredTechnicalValidationDateWarningMessageSender(Car car)
        {
            if (CarTechnicalDateValidationCheck.IsCarTechnicalValidationExpireLessThanThirtyDays(car))
            {
                return "Warning! The car's technical validation will expire less than 30 days!";
            }
            else
            {
                return "The car's technical validation is valid!";
            }
        }

        public static string ExpiredInsuranceValidationDateWarningMessageSender(Car car)
        {
            if (CarInsuranceDateValidationCheck.IsCarInsuranceValidationExpireLessThanThirtyDays(car))
            {
                return "Warning! The car's insurance will expire less than 30 days!";
            }
            else
            {
                return "The car's insurance is valid!";
            }
        }
    }
}
