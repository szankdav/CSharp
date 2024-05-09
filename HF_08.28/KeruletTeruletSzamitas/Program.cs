using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeruletTeruletSzamitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Egy 5 cm oldalú négyzet kerülete: {KeruletTerulet.Kerulet(5)}");
            Console.WriteLine($"Egy 5 x 10 cm-es téglalap kerülete: {KeruletTerulet.Kerulet(5, 10)}");
            Console.WriteLine($"Egy 5 x 10 x 15 cm oldalú háromszög kerülete: {KeruletTerulet.Kerulet(5, 10, 15)}");
            Console.WriteLine($"Egy 5 cm sugarú kör kerülete: {KeruletTerulet.Kerulet(5, "kor")}");

            Console.WriteLine($"Egy 5 x 10 cm-es téglalap területe: {KeruletTerulet.Terulet(5, 10)}");
            Console.WriteLine($"Egy 5 cm oldalú négyzet területe: {KeruletTerulet.Terulet(5)}");
            Console.WriteLine($"Egy 5 cm oldallal, és 12 cm hozzátartozó magassággal rendelkező háromszög területe: {KeruletTerulet.Terulet(5, 12, "haromszog")}");
            Console.WriteLine($"Egy 5 cm sugarú kör területe: {KeruletTerulet.Terulet(5, "kor")}");
            Console.ReadKey();
        }
    }
}
