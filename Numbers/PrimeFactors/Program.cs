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
            createPrimes(5);
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
            
            
            foreach(int z in primes)
            {
                Console.WriteLine(z);
            }
            recSeive(max);
        }

        static void recSeive(int max, int prime = 2)
        {
            List<int> tPrimes = new List<int>(primes);
                foreach (int y in tPrimes)
                {
                    if (y % prime != 0)
                    {
                        primes.Remove(y);
                    }
                }
                primes = tPrimes;
                prime = primes.First();
                Console.WriteLine(prime);
            if(prime < max/2)
            {
                recSeive(max, prime);
            }
        }
    }
}
