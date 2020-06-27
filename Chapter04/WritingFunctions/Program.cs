using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        //with switch expressions showing syntax found on SO for multiple cases on a given output
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            rate = (twoLetterRegionCode) switch 
            {
                "CH" => 0.08M, //Switzerland
                var x when 
                    x == "DK" || //Denmark
                    x == "NO" => 0.25M, //Norway
                var x when
                    x == "GB" ||
                    x == "UK" ||
                    x == "FR" => 0.2M,
                "HU" => 0.27M, //Hungary
                 _ => 0.06M //default
            };
            return amount * rate;
        }


        //with switch statements (full code example from book)
        // static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        // {
        //     decimal rate = 0.0M;
        //     switch (twoLetterRegionCode)
        //     {
        //         case "CH": //Switzerland
        //             rate = 0.08M;
        //             break;
        //         case "DK": //Denmark
        //         case "NO": //Norway
        //             rate = 0.25M;
        //             break;
        //         case "GB": //United Kingdom
        //         case "FR": //France
        //             rate = 0.2M;
        //             break;
        //         case "HU": //Hungary
        //             rate = 0.27M;
        //             break;
        //         case "OR": //Oregon
        //         case "AK": //Alaska
        //         case "MT": //Montana
        //             rate = 0.0M; break;
        //         case "ND": //North Dakota
        //         case "WI": //Wisconsin
        //         case "ME": //Maine
        //         case "VA": //Virgina
        //             rate = 0.05M; 
        //             break;
        //         case "CA": //California
        //             rate = 0.0825M;
        //             break;
        //         default: //most US states
        //             rate = 0.06M;
        //             break;
        //     }
        //     return amount * rate;
        // }

        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();

            Write("Enter a two-letter region code: ");
            string region = ReadLine().ToUpper();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }
        static void TimesTable (byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter anumber between 0 and 255: ");

                isNumber = byte.TryParse(
                    ReadLine(), out byte number);
                
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }
        static void Main(string[] args)
        {
            // RunTimesTable();
            RunCalculateTax();
        }
    }
}
