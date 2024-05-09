using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Car
    {
        private int hp;
        private string color;

        public int Hp { get => hp; set => hp = value; }
        public string Color { get => color; set => color = value; }

        public Car(int hp, string color)
        {
            Hp = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The car's horsepower is: {Hp}, and color is: {Color}.....default");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
