using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznalokDB
{
    internal static class CSVMentes
    {
        public static void CSVFajlMentes(Felhasznalo felhasznalo, string fileName)
        {
            StreamWriter streamWriter = new StreamWriter(fileName, true);

            streamWriter.WriteLine(felhasznalo.felhasznaloToCSV());

            streamWriter.Close();
        }
    }
}
