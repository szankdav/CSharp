using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyInheritanceChallenge2
{
    internal class Trainee : Employee
    {
        private int workingHours;
        private int schoolHours;

        public int WorkingHours { get => workingHours; set => workingHours = value; }
        public int SchoolHours { get => schoolHours; set => schoolHours = value; }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours) : base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"My learning hours is {SchoolHours}");
        }

        public new void Work()
        {
            Console.WriteLine($"My working hour is {WorkingHours}");
        }
    }

}
