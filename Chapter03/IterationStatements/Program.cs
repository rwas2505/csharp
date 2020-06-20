using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;
            int counter = 0;

            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                counter++;
            }
            while (password != "Pa$$w0rd" && counter <3);

            if (password == "Pa$$w0rd")
            {
            WriteLine("Correct!");
            }

            else if (counter == 3)
            {
            WriteLine("Exceeded maximum number of attempts!");   
            }

            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            string[] names = {"Adam", "Barry", "Charlie"};

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
