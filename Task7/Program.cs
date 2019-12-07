using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Boliubash", "Pavlo");
            employee.Position = "Dev"; 
            employee.Experience = 3; 

            Console.WriteLine($"{employee.LastName} {employee.Name} {employee.Position}");
            employee.ShowSalary();
        }
    }
}
