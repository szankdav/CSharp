using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeruletTeruletSzamitas
{
    /// <summary>
    /// Alapvető geometriai alakzatok kerületét és területét kiszámító funkció osztály
    /// </summary>
    static class KeruletTerulet
    {
        /// <summary>
        /// A négyzet kerületét kiszámító funkció
        /// </summary>
        /// <param name="a">A négyzet egyik oldala</param>
        /// <returns>A négyzet kerülete</returns>
        public static double Kerulet(double a)
        {
            return a * 4;
        }

        /// <summary>
        /// A téglalap kerületét kiszámító funckió
        /// </summary>
        /// <param name="a">A téglalap egyik oldala</param>
        /// <param name="b">A téglalap másik oldala</param>
        /// <returns>A téglalap kerülete</returns>
        public static double Kerulet(double a, double b)
        {
            return 2 * (a + b);
        }

        /// <summary>
        /// A háromszög kerületét kiszámító funkció
        /// </summary>
        /// <param name="a">A háromszög A oldala</param>
        /// <param name="b">A háromszög B oldala</param>
        /// <param name="c">A háromszög C oldala</param>
        /// <returns>A háromszög kerülete</returns>
        public static double Kerulet(double a, double b, double c)
        {
            return a + b + c;
        }

        /// <summary>
        /// A kör kerületét kiszámító funkció
        /// </summary>
        /// <param name="r">A kör sugara</param>
        /// <param name="kor">Megkülönböztetés</param>
        /// <returns>A kör kerülete</returns>
        public static double Kerulet(double r, string kor = "kor")
        {
            return 2 * r * Math.PI;
        }

        /// <summary>
        /// A téglalap területét kiszámító funkció
        /// </summary>
        /// <param name="a">A téglalap A oldala</param>
        /// <param name="b">A téglalap B oldala</param>
        /// <returns>A téglalap területe</returns>
        public static double Terulet(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// A négyzet területét kiszámító funkció
        /// </summary>
        /// <param name="a">A négyzet A oldala</param>
        /// <returns>A négyzet területe</returns>
        public static double Terulet(double a)
        {
            return Math.Pow(a, 2);
        }

        /// <summary>
        /// A kör területét kiszámító funkció
        /// </summary>
        /// <param name="r">A kör sugara</param>
        /// <returns>A kör területe</returns>
        public static double Terulet(double r, string kor = "kor")
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        /// <summary>
        /// A háromszög területét kiszámító funkció
        /// </summary>
        /// <param name="a">A háromszög A oldala</param>
        /// <param name="m">A háromszög A oldalához tartozó magasság</param>
        /// <param name="haromszog"></param>
        /// <returns>A háromszög területe</returns>
        public static double Terulet(double a, double m, string haromszog = "haromszog")
        {
            return (a * m) / 2;
        }
    }
}
