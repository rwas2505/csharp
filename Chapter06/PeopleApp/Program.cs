using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        //p.189 add a method with a matching signature that gets a reference to the Person object from the sender parameter and outputs some information about them.
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }


        static void Main(string[] args)
        {
            var harry = new Person {Name = "Harry"};
            var mary = new Person {Name = "Mary"};
            var jill = new Person {Name = "Jill"};

            //call instance method
            var baby1 = mary.ProcreateWith(harry);

            //call static method
            var baby2 = Person.Procreate(harry, jill);

            //call an operator
            var baby3 = harry * mary;

            // WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            // WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            // WriteLine($"{jill.Name} has {jill.Children.Count} children.");

            // WriteLine($"{harry.Name}'s first child is namedd \"{harry.Children[0].Name}\".");
            
            // WriteLine($"5! is {Person.Factorial(5)}");

            //p.189 add a statement to assign the method to the delegate field
            // harry.Shout += Harry_Shout;
            //add statements to call the Poke method four times
            // harry.Poke();
            // harry.Poke();
            // harry.Poke();
            // harry.Poke();

            //p.192 add statements that create an array of Person instances and writes the items to the console, and then attempts to sort the array and writes the items to the console again.
            // Person[] people =
            // {
            //     new Person {Name = "Simon"},
            //     new Person {Name = "Jenny"},
            //     new Person {Name = "Adam"},
            //     new Person {Name = "Richard"}
            // };
            // WriteLine("Initial list of people:");
            // foreach (var person in people)
            // {
            //     WriteLine($"{person.Name}");
            // }
            // WriteLine($"Use Person's IComparable implementation to sort:");
            // Array.Sort(people);
            // foreach (var person in people)
            // {
            //     WriteLine($"{person.Name}");
            // }

            //add statements to sort the array using this alternative implementation p.195
            // WriteLine("Use PersonComparer's IComparer implementation to sort: ");
            // Array.Sort(people, new PersonComparer());
            // foreach (var person in people)
            // {
            //     WriteLine($"{person.Name}");
            // }

            //p.199-201
            // var t1 = new Thing();
            // t1.Data = 42;
            // WriteLine($"Thing with an integer: {t1.Process(42)}");

            // var t2 = new Thing();
            // t2.Data = "apple";
            // WriteLine($"Thing with a string: {t2.Process("apple")}");

            // var gt1 = new GenericThing<int>();
            // gt1.Data = 42;
            // WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            // var gt2 = new GenericThing<string>();
            // gt2.Data = "apple";
            // WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            //p.202
            string number1 = "4";
            byte number2 = 3;
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");
            WriteLine($"{number2} squared is {Squarer.Square(number2)}");

        }
    }
}
