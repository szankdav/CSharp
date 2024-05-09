using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, };
            int[] numbers2 = { 6, 7, 8, 9, 10 };

            int result1 = 0;
            int result2 = 0;

            // Ket object letrehozasa a szalak allapotanak kovetesere
            object lockObject1 = new object();
            object lockObject2 = new object();

            // Ket szal letrehozasa a szam tombok osszegzesere
            Thread thread1 = new Thread(() => result1 = new ArrayManagement().SumArray(numbers1, lockObject1, "Thread 1"));
            Thread thread2 = new Thread(() => result2 = new ArrayManagement().SumArray(numbers2, lockObject2, "Thread 2"));

            // Szalak inditasa
            thread1.Start();
            thread2.Start();

            // Egymasnak dobaljak a lehetoseget a futasra
            thread1.Join(); // Blokkolja a thread 1 szalat
            thread2.Join(); // Blokkolja a thread 2 szalat

            int finalResult = result1 + result2;
            Console.WriteLine(finalResult);

            Console.ReadKey();
        }
    }
}
