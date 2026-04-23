namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("mohamed", 20, 85.5);
            student1.displayInfo();
            student1.setAge(4); 
            student1.setGrade(105);
            student1.setAge(22); 
            student1.setGrade(90); 
            student1.displayInfo();
        }
    }
}
