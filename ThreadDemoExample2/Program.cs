using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemoExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            // Ket szal letrehozasa
            // Mindket szal a counter objektumon dolgozik
            Thread thread1 = new Thread(() => new CounterManagement().IncrementCounter(counter, "Thread 1"));
            Thread thread2 = new Thread(() => new CounterManagement().IncrementCounter(counter, "Thread 2"));

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Vegleges ertek: {counter.Value}");

            Console.ReadKey();
        }
    }
}
