using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = { 1, 5, 20, 30, 42, 4, 2, 3 };
            List<int> list = new List<int>(tomb.Where(x => x < 10));
            foreach (int listSzam in list)
            {
                Console.WriteLine(listSzam);   
            }
            int szam = tomb.Where(x => x < 10).Max(x => x);
            Console.WriteLine(szam);

            Console.ReadKey();
        }
    }
}
