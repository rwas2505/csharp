using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace EratosthenesV2._0
{
    class Program
    {
        private static IEnumerable<int> GetPrimeFactors(int value, Eratosthenes eratosthenes)
        {
            List<int> factors = new List<int>();
        
            foreach (int prime in eratosthenes)
            {
                while (value % prime == 0)
                {
                    value /= prime;
                    factors.Add(prime);
                }
        
                if (value == 1)
                {
                    break;
                }
            }

            return factors;
        }


        static void Main(string[] args)
        {
            Eratosthenes eratosthenes = new Eratosthenes();
 
            IEnumerable<int> factors = GetPrimeFactors(120, eratosthenes);

            string itesting = "";
            
            foreach (int i in factors)
            {
                //Console.Write("{0} ", i);   // Outputs "2 2 2 3 5"
                itesting += $"{i.ToString()} ";
            }

            WriteLine(itesting);
            
        }

    }
    public class Eratosthenes : IEnumerable<int>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private static List<int> _primes = new List<int>();
        private int _lastChecked;

        private bool IsPrime(int checkValue)
        {
            bool isPrime = true;
        
            foreach (int prime in _primes)
            {
                if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
                {
                    isPrime = false;
                    break;
                }
            }
        
            return isPrime;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int prime in _primes)
            {
                yield return prime;
            }
        
            while (_lastChecked < 999)
            {
                _lastChecked++;
        
                if (IsPrime(_lastChecked))
                {
                    _primes.Add(_lastChecked);
                    yield return _lastChecked;
                }
            }
        }
    
        public Eratosthenes()
        {
            _primes.Add(2);
            _lastChecked = 2;
        }


    }







}
