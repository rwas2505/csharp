using System;
using static System.Console;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number = 8;
            // double number2 = 8.2;
            // int maxInt = int.MaxValue;
            // int y = 5;

            // WriteLine($"Int number is: {number}");
            // WriteLine($"Int number divided by 2 is: {number / 2}");
            // WriteLine($"Int number divided by 0 is: {number / 0}");

            // WriteLine($"Double number is: {number2}");
            // WriteLine($"Double number divided by 2 is: {number2 / 2}");
            // WriteLine($"Double number divided by 0 is: {number2 / 0}");

            // WriteLine($"MaxInt  is: {maxInt}");
            // WriteLine($"MaxInt + 1  is: {maxInt + 1}");

            // WriteLine($"y before increment is {y}");
            // int x = y++;
            // int x = ++y;
            // WriteLine($"y is {y}");
            // WriteLine($"x = y++; x is {x}");
            // WriteLine($"x = ++y; x is {x}");


            //Exercise 3.5
        
            //1.
            // int x = 3;
            // int y = 2 + ++x;

            // WriteLine($"x is {x} and y is {y}");
            //guess: x is 4, y is 6 (CORRECT)

            //2.
            // int x = 3 << 2;
            // int y = 10 >> 1;

            //shift operators shift bits
            // WriteLine($"x is {x} and y is {y}");
            //answer (no clue how to guess): x is 12 and y is 5

            //3. 
            int x = 10 & 8;
            int y = 10 | 7;

            //guess x is true and y is true
            WriteLine($"x is {x} and y is {y}");
            //answer: x is 8 and y is 15. When I tried to assign x and y as bool received error, cannot implicitly convert type 'int' to 'bool'. The answer has to do with bitwise logical & and |`



        }
    }
}
