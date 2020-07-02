using System;
using static System.Console;
using System.Collections.Generic;

namespace Eratosthenes
{
    class Program
    {
        //http://www.blackwasp.co.uk/PrimeFactors.aspx
        private static bool IsPrime(long checkValue)
        {
            bool isPrime = true;
        
            foreach (long prime in _primes)
            {
                if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
                {
                    isPrime = false;
                    break;
                }
            }
        
            return isPrime;
        }
        private static List<long> _primes = new List<long>();
        static void Main(string[] args)
        {
            _primes.Add(2);
            Write(2);

            for (long checkValue = 3; checkValue <= 999; checkValue += 2)
            {
                if (IsPrime(checkValue))
                {
                    _primes.Add(checkValue);
                    // Console.Write("\t{0}", checkValue);
                }
            }

            // _primes.ForEach(WriteLine);
            WriteLine(_primes.IndexOf(3));
        }
    }
}
