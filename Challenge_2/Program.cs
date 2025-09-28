using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked for the first number, value stored in variable named 'number1'
            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // The user is asked for the second number, value stored in variable named 'number2'
            Console.WriteLine("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Variable 'lowestNumber' is created
            int lowestNumber = 0;

            // The lowest number is found out
            if (number1 < number2)
            {
                lowestNumber = number1;
            }

            if (number2 <= number1)
            {
                lowestNumber = number2;
            }

            // The result is printed to the user
            Console.WriteLine($"The lowest number is: {lowestNumber}");
        }
    }
}
