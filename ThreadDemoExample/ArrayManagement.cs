using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemoExample
{
    internal class ArrayManagement
    {
        public int SumArray(int[] numbers, object lockObject, string threadName)
        {
            int sum = 0;
            foreach (var number in numbers) 
            {
                // Az allapotvaltozo zarolasaval biztositjuk a szinkronizaciot
                lock (lockObject) // A lock zarolja mas szalak elol az aktualis vegrehajtast. Egyszerre egy idoben nem fog ket ertek kiirodni
                {
                    sum += number;
                    Console.WriteLine($"{threadName} - Ertek: {sum}");
                }
                Thread.Sleep(100); // Atadjuk a vezerlest egy masik szalnak, hogy felvaltva tudjanak futni. Az aktualis szal, ami eppen fut, altatasba kerul, megall
                //Valo eletben nincs szukseg ra, itt a pelda miatt hasznaljuk, hogy at adja egymasnak a ket szal a lehetoseget, kulonben tul gyorsan futna le, hogy lassunk belole valamit erdemlegesen
            }
            return sum;
        }
    }
}
