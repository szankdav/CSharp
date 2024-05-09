using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    static class CSVFajl
    {
        static string szeparator = ";"; //?????
        static string sorveg = "\n"; //?????

        public static void CSVMentes(List<ICSVMentes> adatok, string fajlNev)
        {
            StreamWriter writer = new StreamWriter(fajlNev);
            foreach (ICSVMentes item in adatok)
            {
                writer.Write(item.CSVFormatum());
            }
            writer.Close();
        }
    }
}
