namespace Packt.Shared
{
    public partial class Person
    {
        //#######DEFINING READONLY PROPERTIES#######
        //a property defined using C# 1-5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        //two properties defined using C# 6+ lambda expression syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        //###########################################

        //#######DEFINING SETTABLE PROPERTIES#######
        public string FavoriteIceCream{ get; set;} //auto-syntax, even though you have not manually created a field to store the person's favoriteice cream, it is there,automatically created by the compiler for you.

        //Sometimes you need more control over what happens when a property is set. In this scenario, you must use a more detailed syntax and manually create a private field to store the value for the property.

        //string field
        private string favoritePrimaryColor;

        //string property
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a primary color. " + "Choose from: red, green, blue.");
                }
            }
        }

        //###########################################

        //#######DEFINING SETTABLE PROPERTIES#######
        //define an indexer to get and set a child using the index of the child
        //indexers
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

        //Good Practice: Only use indexers if it makes sense to use the square bracket, also known as array syntax. As you can see from the preceding example, indexers rarely add much value
        //###########################################

    }
}