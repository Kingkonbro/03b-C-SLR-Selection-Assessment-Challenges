using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked to enter the amount of faces on the dice, then this vaule is stored in the variable 'faces'
            Console.Write("Enter the number of faces on the dice: ");
            int faces = Convert.ToInt32(Console.ReadLine());

            // A random number is generated 
            Random rand = new Random();
            int r = rand.Next(1, (faces + 1));

            // The result is printed to the user
            Console.WriteLine($"The result of the dice roll is: {r}");

        }
    }
}
