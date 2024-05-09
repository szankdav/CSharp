using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new BMW("Z4", 230, "black"),
                new Audi("A8", 200, "blue")
            };

            foreach (var car in cars) 
            {
                car.Repair();
                car.ShowDetails();
            }

            Car a = new BMW("X", 23, "red");
            a.Repair();
            a.ShowDetails();
            Console.ReadKey();
        }
    }
}
