using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    internal interface ICSVMentes
    {
        string CSVFormatum(string szeparator = ";", string sorveg = "\n");
    }
}
