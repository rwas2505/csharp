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

            // bob.Children.Add(new Person { Name = "Alfred" });
            // bob.Children.Add(new Person { Name = "Zoe" });

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
            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());
        }
    }
}
