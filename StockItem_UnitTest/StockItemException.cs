using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockItem_UnitTest
{
    public class StockItemException : Exception
    {
        public StockItemException(string message) : base(message)
        {

        }
    }
}
