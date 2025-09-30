using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A random new number is generated between 1 and 10
            Random rnd = new Random();
            int r = rnd.Next(1, 11);

            // The user is asked to guess the number
            Console.Write("Guess a number between 1 and 10: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            // The users guess is compared to the random number to check if its higher, lower or equal
            if (guess < r)
            {
                Console.WriteLine("Higher!");
            }

            else if (guess > r)
            {
                Console.WriteLine("Lower!");
            }

            else
            {
                Console.WriteLine("Your guess is correct!!!");
            }

        }
    }
}
