using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {

        static Random rng = new Random();
        static int numberOfHeads = 0;
        static int numberOfTails = 0;

        static void Main(string[] args)
        {
        }

        public static void FlipCoins(int numberOfFlips)
        {
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

    }
}
