using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvNyilvantarto
{
    internal class DatabaseExceptionManage : Exception
    {
        string defaultExceptionMessage;

        public string DefaultExceptionMessage { get => defaultExceptionMessage; set => defaultExceptionMessage = value; }

        public DatabaseExceptionManage(string createdMessage, string systemMessage) :base(systemMessage)
        {
            DefaultExceptionMessage = systemMessage;
        }
    }
}
