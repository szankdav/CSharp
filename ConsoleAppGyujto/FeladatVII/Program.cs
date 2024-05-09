using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int jegy;
            bool isNumber;

            do
            {
                Console.WriteLine("Kerem adja meg a jegyet:");
                isNumber = int.TryParse(Console.ReadLine(), out jegy);

                if (!isNumber)
                {
                    Console.WriteLine("A beirt adat nem megfelelo!");
                }

            } while (!isNumber);

            switch (jegy)
            {
                case 1:
                    Console.WriteLine("Elegtelen");
                    break;
                case 2:
                    Console.WriteLine("Elegseges");
                    break;
                case 3:
                    Console.WriteLine("Kozepes");
                    break;
                case 4:
                    Console.WriteLine("Jo");
                    break;
                case 5:
                    Console.WriteLine("Jeles");
                    break;
                default:
                    Console.WriteLine("A beirt szam nem megfelelo!");
                    break;
            }*/
            Console.WriteLine("Kerem adja meg a jegyet:");
            char charJegy = Console.ReadKey().KeyChar;
            //Console.Write("\n\r");
            Console.Write(Environment.NewLine);
            switch (charJegy)
            {
                case '1':
                    Console.WriteLine("Elegtelen");
                    break;
                case '2':
                    Console.WriteLine("Elegseges");
                    break;
                case '3':
                    Console.WriteLine("Kozepes");
                    break;
                case '4':
                    Console.WriteLine("Jo");
                    break;
                case '5':
                    Console.WriteLine("Jeles");
                    break;
                default:
                    Console.WriteLine("A beirt szam nem megfelelo!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
