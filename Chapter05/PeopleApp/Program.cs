using Packt.Shared;
using static System.Console;
using System;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //bob
            var bob = new Person();

            bob.Name = "Bob Smith";

            bob.DateOfBirth = new DateTime(1965, 12, 22);   

            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            //bob.BucketList = (WondersOfTheAncientWorld)18; is the same as above but not as clear

            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });

            //call GetFruit method and then output the tuple's fields
            (string,int) fruit = bob.GetFruit();
            // WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            //call GetNamedFruit method which is a tuple with named fields
            var fruitNamed = bob.GetNamedFruit();
            // WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

            // WriteLine($"{bob.Name} was born on {bob.DateOfBirth: dddd, d MMMM yyyy}");
            // WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. It's integer is {(int)bob.FavoriteAncientWonder}.");
            // WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            // WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            // WriteLine($"{bob.Name} is a {Person.Species}.");
            // WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

            // for (int child = 0; child < bob.Children.Count; child++)
            // {
            //     WriteLine($"  {bob.Children[child].Name}");
            // }

            //alice
            var alice = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            // WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dd MMM yy}");

            BankAccount.InterestRate = 0.012M; //store a shared value

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            // WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest.");

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;

            // WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest.");

            //instantiate new person and then output its initial field values (p.160)
            var blankPerson = new Person();

            // WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}");

            //using the 2nd constructor to set initial values
            var gunny = new Person("Gunny", "Mars");

            // WriteLine($"{gunny.Name} of {gunny.HomePlanet} was creatd at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}.");

            //call the two methods from the Person class
            // bob.WriteToConsole();
            // WriteLine(bob.GetOrigin());

            //create two tuples made of a string and int value 
            //In C# 7.1 and later, the second thing can infer the names Name and Count
            // var thing1 = ("Neville", 4);
            // WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            // var thing2 = (bob.Name, bob.Children.Count);
            // WriteLine($"{thing2.Name} has {thing2.Count} children");
            
            //deconstruct return values into two separate variables from tuple
            (string fruitName, int fruitNumber) = bob.GetFruit();
            // WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            //call two methods from Person class and write return values to console
            // WriteLine(bob.SayHello());
            // WriteLine(bob.SayHello("Emily"));

            //call optional parameters method from Person class
            // WriteLine(bob.OptionalParameters());
            //pass values for command and number parameters
            // WriteLine(bob.OptionalParameters("Jump!", 98.5));
            //using named parameters so the order can be swapped
            // WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
            //using positional order for the command param, skipping the number param, and using the named active param 
            // WriteLine(bob.OptionalParameters("Poke!", active: false));

            //pass variables into PassingParameters method
            // int a = 10;
            // int b = 20;
            // int c = 30;

            // WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            // bob.PassingParameters(a, ref b, out c);
            // WriteLine($"After: a = {a}, b = {b}, c = {c}");

            //simplify the code that uses the out variable in C# 7.0 and later by declaring inline
            // int d = 10;
            // int e = 20;
            // WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
            //simplified C# 7.0 syntax for the out parameter 
            // bob.PassingParameters(d, ref e, out int f);
            // WriteLine($"After: d = {d}, e = {e}, f = {f}");

            //DEFINING READONLY PROPERTIES (172)
            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            // WriteLine(sam.Origin);
            // WriteLine(sam.Greeting);
            // WriteLine(sam.Age);

            //DEFINING SETTABLE PROPERTIES
            //add statements to set Sam's favorite ice cream and color, and then write them to the console
            sam.FavoriteIceCream = "Chocolate Fudge";

            // WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

            sam.FavoritePrimaryColor = "Red";

            // WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

            //DEFINING INDEXERS
            sam.Children.Add(new Person { Name = "Charlie" });
            sam.Children.Add(new Person { Name = "Ella"});

            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");
            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");
            //Good Practice: Only use indexers if it makes sense to use the square bracket, also known as array syntax. As you can see from the preceding example, indexers rarely add much value



        }
    }
}
