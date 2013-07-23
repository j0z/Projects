using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibSeq
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Generate The Fibonacci Sequence to the nth number or to the entered number.");
            Console.WriteLine("Do you want to: \n (1) Generate nth numbers \n (2) Generate TO n");
            string selection = Console.ReadLine();
            int n = int.Parse(selection);

            switch (n)
            {
                case 1:
                    nthNumbers();
                    break;
                case 2:
                    numberTo();
                    break;
                default:
                    Console.WriteLine("Not an option");
                    Main();
                    break;
            }
            }


        static void nthNumbers()
        {
            Console.WriteLine("How many digits of the Fib Sequence would you like?");
            string rawNumber = Console.ReadLine();

            try
            {
                int number = int.Parse(rawNumber);
                genFib(number);
            }
            catch
            {
                Console.WriteLine("Not a number!");
                nthNumbers();
            }

        }

        static void numberTo()
        {
            Console.WriteLine("What number should we count to?");
            string s = Console.ReadLine();
            int max = int.Parse(s);

            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);

            while (c < max)
            {
                c = a + b;
                a = b;
                b = c;
                if(c<max)
                    Console.WriteLine(c);
            }

            Console.Read();
        }

        static void genFib(int number)
        {
            int a = 0;
            int b = 1;
            int c;

            int count = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);

            while(count < number-2) //Because we already displayed the first 2 numbers.
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
                count++;
            }

            Console.Read();
        }
    }
}
