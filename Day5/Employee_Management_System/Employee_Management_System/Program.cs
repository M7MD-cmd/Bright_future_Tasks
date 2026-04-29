namespace Employee_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Manager("Ali", 10000));
            employees.Add(new Developer("Omar", 8000));

            foreach (var emp in employees)
            {
                emp.DisplayEmployeeInfo();
                Console.WriteLine("-------------------");
            }
        }
    }
}
