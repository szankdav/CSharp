using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_UnitTest
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base(message)
        {

        }
    }
}
