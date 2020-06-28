using System;
using static System.Console;

namespace Debugging
{
    class Program
    {
        /// <summary>
        /// Accepts two double numbers and returns the sum of the two inputs
        /// </summary>
        /// <param name="a">Type double number to add to b</param>
        /// <param name="b">Type double number to add to a</param>
        /// <returns>Sum of type double a and b</returns>
        static double Add(double a, double b)
        {
            return a + b; //deliberate bug!
        }
        static void Main(string[] args)
        {
            double a = 4.5; //or use var
            double b = 2.5;
            double answer = Add(a,b);
            WriteLine($"{a} + {b} = {answer}");
            ReadLine(); //wait for user to press ENTER
        }
    }
}
