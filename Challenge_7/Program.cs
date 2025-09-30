using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random numbers are generated
            Random rand = new Random();
            int r1 = rand.Next(1, 7);
            int r2 = rand.Next(1, 7);
            int r3 = rand.Next(1, 7);

            // The random values are displayed to the user
            Console.WriteLine($"Dice 1: {r1}");
            Console.WriteLine($"Dice 2: {r2}");
            Console.WriteLine($"Dice 3: {r3}");
            
            // 'score' variable is initialized 
            int score = 0;

            if ((r1 == r2) && (r1 == r3) && (r2 == r3))
            {
                score = r1 + r2 + r3;
            }

            if (r1 == r2)
            {
                score = r1 + r2;
            }

            if (r1 == r3)
            {
                score = r1 + r3;
            }

            if (r2 == r3)
            {
                score = r2 + r3;
            }

            // The score is printed to the user
            Console.WriteLine($"Final Score: {score}");
        }
    }
}
