using System;
using EmployeeLibrary;
using System.Collections.Generic;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.WriteLine("There are " + employees.Count + " employees in the list");
            Console.WriteLine("The capacity is " + employees.Capacity);

            Employee emp1 = new Employee() { Name = "Luis", Age = 37, Salary = 200 };
            Employee emp2 = new Employee() { Name = "Juan", Age = 20, Salary = 2000 };

            employees.Add(emp1);
            employees.Add(emp2);

            Console.WriteLine("There are " + employees.Count + " employees in the list");
            Console.WriteLine("The capacity is " + employees.Capacity);

            foreach (Employee emp in employees)
            {
                emp.Salary *= 1.10;
                Console.WriteLine("Name: " + emp.Name + ", Age: " + emp.Age + ", Salary: " + emp.Salary);
            }

            employees.Add(new Employee() { Name = "Sara", Age = 45, Salary = 440 });
            employees.Add(new Employee());
            Console.WriteLine("There are " + employees.Count + " employees in the list");
            Console.WriteLine("The capacity is " + employees.Capacity);

            // Adding michael as second employee
            Employee michael = new Employee();
            michael.Name = "Michael";

            employees.Insert(1, michael);

            // Access employee by index
            Employee secondEmployee = employees[1];
            Console.WriteLine("The name of the second employee is " + secondEmployee.Name);

            employees[3].Name = "Maria";
            employees[3].Salary = 1000;
            Console.WriteLine("The name of the last employee is " + employees[3].Name);

            // Removing employees from the list
            employees.RemoveAt(2);
            Console.WriteLine("There are " + employees.Count + " employees in the list");

            foreach (Employee emp in employees)
            {
                Console.WriteLine("Name: " + emp.Name + ", Age: " + emp.Age + ", Salary: " + emp.Salary);
            }

            employees.Clear();
            Console.WriteLine("There are " + employees.Count + " employees in the list");


            Console.ReadKey();
        }
    }
}
