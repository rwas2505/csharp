using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        //constants
        public const string Species = "Homo Sapien";

        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

    }
}
