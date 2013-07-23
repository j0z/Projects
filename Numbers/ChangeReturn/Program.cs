using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeReturn
{
    class Program
    {

        static float price;
        static float tender;

        enum coins
        {
            penny,
            nickle,
            dime,
            quarter
        };

        static List<coins> change = new List<coins>();
        static void Main(string[] args)
        {
            Console.WriteLine("Price:");
            price = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Tender:");
            tender = Convert.ToSingle(Console.ReadLine());

            chooseCoins();
            countCoins();
        }

        static void chooseCoins()
        {
            float difference = tender - price;

            while (difference > 0)
            {
                if ((difference - .25) >=0)
                {
                    difference -= .25f;
                    change.Add(coins.quarter);
                    continue;
                }
                if ((difference - .1) >=0)
                {
                    difference -= .10f;
                    change.Add(coins.dime);
                    continue;
                }
                if ((difference - .05) >= 0)
                {
                    difference -= .05f;
                    change.Add(coins.nickle);
                    continue;
                }
                else
                {
                    difference -= .01f;
                    change.Add(coins.penny);
                    continue;
                }
            }
        }

        static void countCoins()
        {
            List<coins> quarters = change.FindAll(coin => coin == coins.quarter);
            List<coins> dimes = change.FindAll(coin => coin == coins.dime);
            List<coins> nickles = change.FindAll(coin => coin == coins.nickle);
            List<coins> pennies = change.FindAll(coin => coin == coins.penny);

            Console.WriteLine("There are: \n {0} Quarters \n {1} Dimes \n {2} Nickles \n {3} Pennies", quarters.Count, dimes.Count, nickles.Count, pennies.Count);
            Console.Read();
        }
    }
}
