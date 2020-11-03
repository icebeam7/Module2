using System;
using EmployeeLibrary;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];

            employees[0] = new Employee() { Name = "Luis", Age = 37, Salary = 200 };
            employees[1] = new Employee() { Name = "Juan", Age = 20, Salary = 2000 };
            employees[2] = new Employee() { Name = "Sara", Age = 45, Salary = 440 };
            employees[3] = new Employee() { Name = "Ana", Age = 18, Salary = 7780 };
            employees[4] = new Employee() { Name = "Peter", Age = 31, Salary = 900 };

            foreach (Employee emp in employees)
            {
                Console.WriteLine("Name: " + emp.Name + ", Age: " + emp.Age + ", Salary: " + emp.Salary);
            }

            Console.ReadKey();
        }
    }
}
