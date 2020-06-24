using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After Incrementing: {x}");
                    x++;
                    WriteLine($"After Incrementing: {x}");
                    x++;
                    WriteLine($"After Incrementing: {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I caught the exception.");
            }
        }
    }
}
