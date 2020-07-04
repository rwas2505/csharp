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

            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            //bob.BucketList = (WondersOfTheAncientWorld)18; is the same as above but not as clear

            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });

            // WriteLine($"{bob.Name} was born on {bob.DateOfBirth: dddd, d MMMM yyyy}");
            // WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. It's integer is {(int)bob.FavoriteAncientWonder}.");
            // WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            WriteLine($"{bob.Name} has {bob.Children.Count} children:");

            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"  {bob.Children[child].Name}");
            }

            var alice = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            // WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dd MMM yy}");
        }
    }
}
