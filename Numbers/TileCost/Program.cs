using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileCost
{
    class Program
    {
        static float tileSize;
        static float tileCost;
        static float floorWidth;
        static float floorHeight;

        static void Main(string[] args)
        {
            Console.WriteLine("How big are the tiles? (Square tiles only)");
            tileSize = float.Parse(Console.ReadLine());
            
            Console.WriteLine("How wide is the room?");
            floorWidth = float.Parse(Console.ReadLine());

            Console.WriteLine("What's its height?");
            floorHeight = float.Parse(Console.ReadLine());

            Console.WriteLine("How much are the tiles?");
            tileCost = float.Parse(Console.ReadLine());

            Console.WriteLine(calculateCost());
            Console.Read();
        }

        static float calculateCost()
        {
            int numTiles = Convert.ToInt32((floorWidth / tileSize) * (floorHeight / tileSize));

            return numTiles * tileCost;
        }
    }
}
