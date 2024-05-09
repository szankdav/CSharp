using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class BMW : Car
    {
        private string model;
        private string brand = "BMW";

        public string Model { get => model; set => model = value; }
        public string Brand { get => brand; set => brand = value; }

        public BMW(string model, int hp, string color) : base(hp, color)
        {
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"The {brand} car's horsepower is: {Hp}, and color is: {Color}");
        }

        public override void Repair()
        {
            Console.WriteLine($"The {Brand} {Model} was repaired!");
        }
    }
}
