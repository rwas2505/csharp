using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int y = 1; y < 101; y++)
            {
                if (y % 3 == 0 && y % 5 == 0)
                {
                    WriteLine("FizzBuzz");
                }
                else if (y % 3 == 0)
                {
                    WriteLine("Fizz");
                }
                else if (y % 5 == 0)
                {
                    WriteLine("Buzz");
                }
                else 
                {
                    WriteLine(y);
                }
            }
        }
    }
}
