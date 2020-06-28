using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {

        /// <summary>
        /// Pass a 32 bit integer and it will return its factorial
        /// </summary>
        /// <param name="number">Number is a 32 bit integer</param>
        /// <returns>Factorial of input integer</returns>
        static int Factorial (int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number==1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number-1);    
            }
        }

        /// <summary>
        /// Prompts user to enter a number. If number is a valid integer, Factorial is calculated. Otherwise a message is displayed stating the user did not enter a valid number.
        /// </summary>
        static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number: ");

                isNumber = int.TryParse(ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"{number:N0}! = {Factorial(number):N0}");
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while(isNumber);
        }


        //with switch expressions showing syntax found on SO for multiple cases on a given output
        /// <summary>
        /// Pass a decimal purchase amount and a string two letter region code and return the amount of tax required for the amount in that country.
        /// </summary>
        /// <param name="amount">Decimal amount representing an items purchase price before tax.</param>
        /// <param name="twoLetterRegionCode">Two letter string representing the region's code.</param>
        /// <returns>Returns a decimal value that represents the amount of tax required for the amount in that region.</returns>
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

        /// <summary>
        /// Receives a byte-number and prints the numbers times table to the console from 1 to 12.
        /// </summary>
        /// <param name="number">Number is of type byte</param>
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

        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g.static 1,2,3, and so on.</param>
        /// <returns>Number as an ordinal value e.g.static 1st, 2nd, 3rd, and so on.</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit = numberAsText[numberAsText.Length - 1];
                    string suffix = string.Empty;
                    switch (lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;
                    }
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOridnal()
        {
            for (int number = 1; number <=40; number++)
            {
                Write($"{CardinalToOrdinal(number)}");
                WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            // RunCardinalToOridnal();
            RunFactorial();
        }
    }
}
