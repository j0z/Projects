using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi2Nth
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Display Pi to the nth digit.");
            takeNumber();
        }


        static void takeNumber()
        {
            Console.WriteLine("Please enter a number");
            string digit = Console.ReadLine();

            try
            {
                int nthNumber = Convert.ToInt32(digit);
                displayPi(nthNumber);
            }
            catch
            {
                Console.WriteLine("Not a number! Try again");
                takeNumber();
            }
        }
        static void displayPi(int digits)
        {
            double final = Math.Round(Math.PI, digits);
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
}
