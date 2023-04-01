using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant Patterns  
            var employee = new Employee() { Id = 1, Name = "John Doe", Age = 0 };
            if (employee.Age is 0)
                Console.WriteLine($"{employee.Name} has an age of zero");
            // Null Patterns  
            var employeeWithNull = new Employee() { Id = 1, Age = 30 };
            if (employeeWithNull.Name is null)
                Console.WriteLine($"The employee with Id: {employeeWithNull.Id} has a name that is null");
            //Negated Patterns  
            var employeeWithoutNull = new Employee() { Id = 1, Name = "John Doe", Age = 30 };
            if (employeeWithoutNull.Name is not null)
                Console.WriteLine($"{employeeWithoutNull.Name} name is not null");
            //Type Patterns  
            var employeeType = new Employee() { Id = 1, Name = "John Doe", Age = 30 };
            if (employeeType is Employee emp)
                Console.WriteLine($" Employee name is {emp.Name}");
            //Property Patterns  
            var employeeProp = new Employee() { Id = 1, Name = "John Doe", Age = 30 };
            if (employeeProp is { Age: 30 })
                Console.WriteLine($" Employe age is {employeeProp.Age}");
            if (employeeProp is { Age: > 25 })
                Console.WriteLine($" Employee age: {employeeProp.Age} is greater than 25");
            Console.ReadKey();
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
