using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary){   }

        public override double CalculateBonus()
        {
            return GetSalary() * 0.2; 
        }
        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"Role: Manager\nBonus: {CalculateBonus()}");
        }
    }
}
