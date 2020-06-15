using System;
#nullable enable

namespace NullHandling
{
    class Address
    {
        public string? Building; //notice the ? an the #nullable enable. Also see .csproj for the nullable element added
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null; //compile error!

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull); //first line of output is blank since it is null 
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            
            thisCouldBeNull = 7;

            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
        }
    }
}
