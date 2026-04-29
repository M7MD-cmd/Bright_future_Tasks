using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Developer : Employee
    {
        public Developer(string name, int salary) : base(name, salary) { }
        public override double CalculateBonus()
        {
            return GetSalary() * 0.1;
        }
        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"Role: Developer\nBonus: {CalculateBonus()}");
        }
    }
}
