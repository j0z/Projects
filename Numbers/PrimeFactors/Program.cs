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

        static void Main(string[] args)
        {
            createPrimes(75000);
            Console.Read();
        }

        static void factor(int number)
        {
            List<int> factors = new List<int>();


        }

        static void createPrimes(int max)
        {
            int n = 2;

            while (n < max)
            {
                primes.Add(n);
                n++;
            }


            //foreach (int z in primes)
            //{
            //    Console.WriteLine(z);
            //}
            //Console.Read();

            
            recSeive(max);

            foreach (int x in primes)
            {
                Console.WriteLine(x); 
                //Console.Read();
            }
            //Console.WriteLine(prime);
            Console.Read();
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
