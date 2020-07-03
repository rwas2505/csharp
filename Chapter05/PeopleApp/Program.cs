using Packt.Shared;
using static System.Console;
using System;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);   

            WriteLine($"{bob.Name} was born on {bob.DateOfBirth: dddd, d MMMM yyyy}");

            var alice = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dd MMM yy}");
        }
    }
}
