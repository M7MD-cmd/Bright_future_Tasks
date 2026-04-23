using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Student
    {
        private string name ;
        private int age;
        private double grade;

        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            if (age > 5)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age must be greater than 5");
            }
        }
        public double getGrade()
        {
            return grade;
        }
        public void setGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grade = grade;
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100");
            }
        }
        public void displayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
