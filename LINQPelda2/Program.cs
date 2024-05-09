using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPelda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 20; i++) 
            { 
                szamok.Add(r.Next(-1000, 1001));
            }
            // LAMBDA LINQ
            int kettovelOszthatoDB = szamok.Count(x => x % 2 == 0);
            // VALOS LINQ
            int kettovelOszthatoDb = (from x in szamok
                                      where x % 2 == 0
                                      select x).Count();

            // LAMBDA LINQ
            List<int> minPluszOtszaznalNagyobbak = szamok.Where(x => x > 500).ToList();
            // VALOS LINQ
            List<int> minPluszOtszaznalNagyobbak2 = (from x in szamok where x > 500 select x).ToList();

            // LAMBDA
            List<int> negyzetSzamok = szamok.Where(x => Math.Sqrt(x) % 1 == 0).ToList();
            // VALOS LINQ
            List<int> negyzetSzamok2 = (from x in szamok where Math.Sqrt(x) % 1 == 0 orderby x select x).ToList();
        }
    }
}
