using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //b has val of 3 because the ++ operator operates after the assignment; this is known as postfix operator. 
            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, b is {b}");

            //if you need to increment before the assignment, then use the prefix operator
            int c = 3;
            int d = ++c; //increment c before assigning it
            WriteLine($"c is {c}, d is {d}");

            int z = 3;
            z++;
            WriteLine($"z is {z}");

            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");
            
        }
    }
}
