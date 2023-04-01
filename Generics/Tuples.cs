using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Tuples
    {
        static void Main3(string[] args)
        {
            var result = GetEmployeeDetails();
            Console.WriteLine($"Name: {result.Name},  Gender: {result.Gender}, Department: {result.Department}, Salary:{result.Salary}");
            Console.ReadLine();
        }
        private static (string Name, double Salary, string Gender, string Department) GetEmployeeDetails()
        {
            return ("David", 2000, "Male", "IT");
        }
    }

}
