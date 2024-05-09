using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemoExample2
{
    internal class CounterManagement
    {
        public void IncrementCounter(Counter counter, string threadName)
        {
            for (int i = 0; i < 5; i++)
            {
                // Szamlalo novelese, de zarolassal
                counter.Increment();
                Console.WriteLine($"{threadName} - Ertek: {counter.Value}");
                // Szunet, hogy a szalak felvaltva fussanak
                Thread.Sleep(100);
            }
        }
    }
}
