using System;
using static System.Console;
using static System.Convert;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number between 0 and 255: ");
            string first = ReadLine();

            Write("Enter another number between 0 and 255: ");
            string second = ReadLine();

            try
            {
            int firstNum = int.Parse(first);
            int secondNum = int.Parse(second);
            WriteLine($"{firstNum} divided by {secondNum} is {firstNum / secondNum}");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }

        }
    }
}
