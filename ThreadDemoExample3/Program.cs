using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemoExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista inicializalasa a veletlen szamokkal
            List<int> numbers = new GenerateNumber().GenerateRandomNumbers(100);

            // Ket szal letrehozasa
            Thread thread1 = new Thread(() => new ProcessList().RemoveEvenNumberFromList(numbers, "Thread 1"));
            Thread thread2 = new Thread(() => new ProcessList().RemoveEvenNumberFromList(numbers, "Thread 2"));

            // Ket szal elinditasa
            thread1.Start();
            thread2.Start();

            // Szalak varakoztatasa
            thread1.Join();
            thread2.Join();

            // Kiiras
            Console.WriteLine($"Vegleges ertekek: {string.Join(", ", numbers.OrderBy(n => n))}");

            Console.ReadKey();
        }
    }
}
