using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    abstract class Employee
    {
        private string Name;
        private int Salary;

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetSalary()
        {
            return Salary;
        }

        public abstract double CalculateBonus();

        public virtual void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}\nSalary: {Salary}");
        }
    }
}
