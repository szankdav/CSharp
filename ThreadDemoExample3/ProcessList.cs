using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemoExample3
{
    internal class ProcessList
    {
        public void RemoveEvenNumberFromList(List<int> numbers, string threadName)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                lock (numbers)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine($"{threadName} - Paros szam kivalasztva: {numbers[i]}");
                        numbers.RemoveAt(i);
                        i--; // Csokkentjuk az indexet, mert egy elemet eltavolitottunk!
                    }
                }
                // Idoszunet, hogy a szalak felvaltva fussanak
                Thread.Sleep(50);
            }

            //foreach (var number in numbers)
            //{
            //    lock (numbers)
            //    {
            //        if (number % 2 == 0)
            //        {
            //            //numbers[numbers.IndexOf(number)] = 2;
            //            Console.WriteLine($"{threadName} - Paros szam kivalasztva: {number}");
            //            numbers.Remove(number);
            //        }
            //    }
            //}
        }
    }
}
