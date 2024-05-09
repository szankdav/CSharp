using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyInheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("David", "Szankovszky", 650000);
            Boss boss = new Boss("Szilvi", "Szankovszky", 12000000,true);
            Trainee trainee = new Trainee("Mufi", "Szankovszky", 200000, 4, 8);
            Employee trainer = trainee;
            boss.Lead();
            trainee.Work();
            employee.Work();
            trainer.Work();
            Console.ReadLine();
        }
    }
}
