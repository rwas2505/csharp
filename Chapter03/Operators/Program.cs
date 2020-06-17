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

            int e = 3;
            e++;
            WriteLine($"e is {e}");
        }
    }
}
