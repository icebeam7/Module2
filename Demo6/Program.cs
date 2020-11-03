using System;
using EmployeeLibrary;
using System.Collections.Generic;

namespace Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Employee> employeeQueue = new Queue<Employee>();
            Console.WriteLine("There are " + employeeQueue.Count + " employees in the queue");

            Employee emp1 = new Employee() { Name = "Luis", Age = 37, Salary = 200 };
            Employee emp2 = new Employee() { Name = "Juan", Age = 20, Salary = 2000 };
            Employee emp3 = new Employee() { Name = "Sara", Age = 45, Salary = 440 };
            Employee emp4 = new Employee() { Name = "Ana", Age = 19, Salary = 200 };
            Employee emp5 = new Employee() { Name = "Charles", Age = 32, Salary = 1000 };

            employeeQueue.Enqueue(emp4);    // Ana
            employeeQueue.Enqueue(emp2);    // Juan
            employeeQueue.Enqueue(emp5);    // Charles

            Employee employee = employeeQueue.Peek();
            Console.WriteLine("Employee from queue is: " + employee.Name);  // Ana
            Console.WriteLine("There are " + employeeQueue.Count + " employees in the queue");  // 3

            employee = employeeQueue.Dequeue();
            Console.WriteLine("Employee from queue is: " + employee.Name);  // Ana
            Console.WriteLine("There are " + employeeQueue.Count + " employees in the queue");  // 2

            employee = employeeQueue.Dequeue();
            Console.WriteLine("Employee from queue is: " + employee.Name);  // Juan
            Console.WriteLine("There are " + employeeQueue.Count + " employees in the queue");  // 1?

            employeeQueue.Enqueue(emp1);
            employee = employeeQueue.Dequeue();

            employeeQueue.Enqueue(emp3);
            Console.WriteLine("There are " + employeeQueue.Count + " employees in the queue");  // 1?

            employeeQueue.Clear();
            Console.WriteLine("There are " + employeeQueue.Count + " employees in the queue");  // 1?

            Console.ReadKey();
        }
    }
}
