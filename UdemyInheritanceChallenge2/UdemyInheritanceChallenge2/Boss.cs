using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyInheritanceChallenge2
{
    internal class Boss : Employee
    {
        private bool hasCompanyCar;

        public bool HasCompanyCar { get => hasCompanyCar; set => hasCompanyCar = value; }

        public Boss(string name, string firstName, int salary, bool hasCompanyCar) : base(name, firstName, salary)
        {
            HasCompanyCar = hasCompanyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I am the leader!");
        }
    }
}
