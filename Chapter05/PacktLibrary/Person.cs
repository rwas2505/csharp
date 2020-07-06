using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : object
    {
        //constants
        public const string Species = "Homo Sapien";

        //read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        //constructors
        public Person()
        {
            //set default values for fields including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name =initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        //methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return("Apples", 5); //method returns a string and int tuple
        }

        //method that returns a tuple with named fields 
        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5); 
        }

        //method without parameter
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        //method with 1 parameter
        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        //method with optional paramaters
        public string OptionalParameters( string command = "Run!", double number = 0.0, bool active = true)
        {
            return $"command is {command}, number is {number}, active is {active}";
        }

        //define a method with three parameters, one in, one ref, and one out param
        public void PassingParameters(int x, ref int y, out int z)
        {
            //out parameters cannot have a default AND must be initialized inside the method
            z = 99;

            //increment each parameter
            x++;
            y++;
            z++;
        }
    }
}
