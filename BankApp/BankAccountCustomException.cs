using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccountCustomException : Exception
    {
        public BankAccountCustomException(string message) :base(message) 
        {
            
        }
    }
}
