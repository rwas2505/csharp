using System;
using static System.Console;

namespace Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 255;
            for (byte i = 0; i < max; i++)
            if (max > 255)
            {
                WriteLine($"Infinite loop will occur unless max is 255 or less. Since max is {max}, loop has been cancelled");
                break;
            }
            else
            {
                WriteLine(i);
            }

            // byte num = 255;
            // num++;
            // num++;
            // WriteLine(num);
        }
    }
}
