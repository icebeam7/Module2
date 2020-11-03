using System;
using EmployeeLibrary;
using System.Collections.Generic;

namespace Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();

            Employee emp2 = new Employee() { Name = "Juan", Age = 20, Salary = 2000 };
            Employee emp3 = new Employee() { Name = "Sara", Age = 45, Salary = 440 };
            Employee emp4 = new Employee() { Name = "Ana", Age = 19, Salary = 200 };
            Employee emp5 = new Employee() { Name = "Charles", Age = 32, Salary = 1000 };

            employeeDictionary.Add("Emp-A", new Employee() { Name = "Luis", Age = 37, Salary = 1000 });
            employeeDictionary.Add("Emp-AX", emp3);
            employeeDictionary.Add("Emp-B1", emp4);
            employeeDictionary.Add("MGR-01", emp5);
            employeeDictionary.Add("Emp-2", emp2);

            // employeeDictionary["any"].Age = 30; //this is an error

            // Iterating over the dictionary
            /*
            foreach (KeyValuePair<string, Employee> entry in employeeDictionary)
            {
                entry.Value.Salary *= 1.10;
                Console.WriteLine("Employee Key: " + entry.Key + ", Name: " + entry.Value.Name);
            }
            */

            foreach (var entry in employeeDictionary)
            {
                entry.Value.Salary *= 1.10;
                Console.WriteLine("Employee Key: " + entry.Key + ", Name: " + entry.Value.Name);
            }

            Console.WriteLine("There are " + employeeDictionary.Count + " employees in the dictionary");

            string search = string.Empty;

            do
            {
                Console.WriteLine("Type the employee key to return a value. Type N to finish");
                search = Console.ReadLine();

                if (employeeDictionary.ContainsKey(search)) // safe way to search for a key
                {
                    Console.WriteLine("Employee found!");
                    Employee emp = employeeDictionary[search];

                    Console.WriteLine("Name: " + emp.Name);
                    Console.WriteLine("Age: " + emp.Age);
                    Console.WriteLine("Salary: " + emp.Salary.ToString("C"));
                }
                else
                    Console.WriteLine("Employee not found");
            } while (search.ToUpper() != "N");

            Console.ReadKey();
        }
    }
}
