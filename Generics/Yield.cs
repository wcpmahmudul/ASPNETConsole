using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Yield
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");
            var people = DataAccess.GetPeople().Take(2);

            foreach (var p in people)
            {
                Console.WriteLine($"Read {p.FirstName} {p.LastName}");
            }

            Console.ReadLine();
        }
    }
    public static class DataAccess
    {
        public static IEnumerable<Person> GetPeople()
        {
            yield return new Person("Chris", "Gayle");
            yield return new Person("Ricky", "Ponting");
            yield return new Person("David", "Warner");
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine($"Initialized user {firstName} {lastName}");
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
