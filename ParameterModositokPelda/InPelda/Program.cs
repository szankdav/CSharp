using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = DateTime.Now;
            Console.WriteLine($"A {datum} datumhoz kepest 1 het mulva {AddWeek(in datum)} lesz. A datum maradt: {datum}");

            Console.ReadKey();
        }

        static DateTime AddWeek(in DateTime alap)
        {
            return alap.AddDays(7);
        }
    }
}
