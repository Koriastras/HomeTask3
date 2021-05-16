using System;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Alice", "Johnson", new DateTime(1990, 9, 6), Gender.Female);
            Console.WriteLine(person.ToString());
            Console.WriteLine("An now she is " + person.Age + " years old");

        }
    }
}

