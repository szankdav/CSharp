using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class CalculatorClass
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nullával való osztás nem értelmezhető!");
            }
            else
            {
                return (double)a / (double)b;
            }
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
