using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemoExample3
{
    internal class GenerateNumber
    {
        public List<int> GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            return Enumerable.Range(1, count).Select(_ => random.Next(1, 100)).ToList();
            // Listat ad vissza
            // Range(mekkora legyen a lista amit returnulunk, hany szam legyen benne, ha nincs select, akkor 1-tol general a countig)
            // Select -> A range-bol az int legyen egy random szam 1 es 100 kozott. A Select fogja a lista minden elemet egyesevel, es megmondja, hogy mi legyen belole. Jelen esetben egy random szam lesz.
            // random.Next(1, 100) random szamok tartomanya, amik a listaban lesznek
            // _ helykitolto, mert nem kap lamdat, ugyan az, mint (int n)
        }
    }
}
