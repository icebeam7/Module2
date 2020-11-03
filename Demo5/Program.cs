using System;
using EmployeeLibrary;
using System.Collections.Generic;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employeesStack = new Stack<Employee>();
            Console.WriteLine("There are " + employeesStack.Count + " employees in the stack");

            Employee emp1 = new Employee() { Name = "Luis", Age = 37, Salary = 200 };
            Employee emp2 = new Employee() { Name = "Juan", Age = 20, Salary = 2000 };
            Employee emp3 = new Employee() { Name = "Sara", Age = 45, Salary = 440 };
            Employee emp4 = new Employee() { Name = "Ana", Age = 19, Salary = 200 };
            Employee emp5 = new Employee() { Name = "Charles", Age = 32, Salary = 1000 };

            employeesStack.Push(emp3);
            employeesStack.Push(emp5);
            Console.WriteLine("There are " + employeesStack.Count + " employees in the stack");

            Employee employee = employeesStack.Peek();
            Console.WriteLine("Employee from stack is: " + employee.Name);
            Console.WriteLine("There are " + employeesStack.Count + " employees in the stack");

            employee = employeesStack.Pop();
            Console.WriteLine("Employee from stack is: " + employee.Name);
            Console.WriteLine("There are " + employeesStack.Count + " employees in the stack");

            foreach (var emp in employeesStack)
            {
                Console.WriteLine(emp.Name);
            }

            employeesStack.Push(emp2);
            employeesStack.Push(emp1);
            employee = employeesStack.Pop();
            Console.WriteLine("Employee from stack is: " + employee.Name);
            Console.WriteLine("There are " + employeesStack.Count + " employees in the stack");

            employeesStack.Clear();
            Console.WriteLine("There are " + employeesStack.Count + " employees in the stack");

            Console.ReadKey();
         }
    }
}
