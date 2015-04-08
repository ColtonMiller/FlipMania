using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);
            FlipForHeads(10000);

            Console.ReadKey();
        }

        public static void FlipCoins(int numberOfFlips)
        {
            Random rng = new Random();
            int numberOfHeads = 0;
            int numberOfTails = 0;

            for (int i = 0; i <= numberOfFlips; i++)
            {
                if (rng.Next(0, 2) == 0)
                {
                    numberOfHeads++;
                }
                else
                {
                    numberOfTails++;
                }
            }

            Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
            Console.WriteLine("Number of Heads: " + numberOfHeads);
            Console.WriteLine("Number of tails: " + numberOfTails);
        }

        public static void FlipForHeads(int numberOfHeads)
        {
            Random rng = new Random();
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;

            while (numberOfHeadsFlipped < numberOfHeads)
            {
                if (rng.Next(0, 2) == 0)
                {
                    totalFlips++;
                    numberOfHeadsFlipped++;
                }
                else
                {
                    totalFlips++;
                }
            }

            Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads.");
            Console.WriteLine("It took " + totalFlips + " to find " + numberOfHeads + " heads.");
        }

    }
}
