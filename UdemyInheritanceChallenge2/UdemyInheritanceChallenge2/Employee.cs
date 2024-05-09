using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyInheritanceChallenge2
{
    internal class Employee
    {
        private string name;
        private string firstName;
        int salary;

        public string Name { get => name; set => name = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public int Salary { get => salary; set => salary = value; }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I am an employee!");
        }

        public virtual void Pause()
        {

        }
    }
}
