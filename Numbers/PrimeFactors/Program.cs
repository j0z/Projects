using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {

        static List<int> primes = new List<int>();

        static void Main()
        {
            Console.WriteLine("Please enter a number to factor, or 'quit' to quit");
                string rawNumber = Console.ReadLine();
                int number = int.Parse(rawNumber);
                createPrimes(number);
                List<int> factors = factor(number);
                foreach (int x in factors)
                {
                    Console.WriteLine(x);
                }
                Console.Read();
        }

        static List<int> factor(int number, List<int> factors = null)
        {
            if (factors == null)
                factors = new List<int>(); 

            foreach(int p in primes)
            {
                if(number % p == 0)
                {
                    factors.Add(p);
                    if ((!primes.Exists(prime => prime == number)) && number != p)
                    {
                        factor(number / p, factors);
                        break;
                    }
                }
            }

            return factors;
        }

        static void createPrimes(int max)
        {
            int n = 2;

            while (n < max)
            {
                primes.Add(n);
                n++;
            }

            recSeive(max);
        }

        static void recSeive(int max, int prime = 2)
        {
            List<int> tPrimes = new List<int>(primes);
                foreach (int y in tPrimes)
                {
                    if ((y % prime == 0) && (prime != y))
                    {
                        primes.Remove(y);
                    }
                }
                tPrimes = primes;
                if (prime != primes.Last())
                {
                    prime = primes[primes.FindIndex(p => p == prime) + 1];
                }
                else
                {
                    primes = tPrimes;
                    return;
                }

                if (prime < max-1)
                {
                    recSeive(max, prime);
                }
                else
                {
                    primes = tPrimes;
                }
        }
    }
}
