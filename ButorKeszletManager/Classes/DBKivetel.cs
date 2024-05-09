using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorKeszletManager
{
    internal class DBKivetel : Exception
    {
        string originalMessage;

        public string OriginalMessage { get => originalMessage; private set => originalMessage = value; }

        public DBKivetel(string message, string originalMessage) : base(message)
        {
            OriginalMessage = originalMessage;
        }
    }
}
