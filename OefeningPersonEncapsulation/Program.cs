using System;

namespace OefeningPersonEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person test = new Person("Dimitri", "Sturm", new DateTime(1998, 11, 30));

            Console.WriteLine($"{test.FullName} is {test.Age} jaar");
            Console.WriteLine($"Aantal instanties: {Person.InstanceCount}");

        }
    }
}
