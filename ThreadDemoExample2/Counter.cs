using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemoExample2
{
    internal class Counter
    {
        private int value = 0;
        private object lockObject = new object();


        // Metodus a szamlalo novelesre zarolassal
        internal void Increment()
        {
            lock (lockObject)
            {
                value++;
            }
        }

        // Amikor lockoljuk, mas nem fogja tudni lekerdezni
        // Property a szamlalo ertekenek lekerdezesere
        public int Value
        {
            get 
            { 
                lock (lockObject) 
                {
                return value;
                }
            }
        }
    }
}
