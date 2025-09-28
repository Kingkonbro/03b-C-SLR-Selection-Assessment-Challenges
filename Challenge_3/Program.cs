using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked for the temperature of the water
            Console.Write("Enter the temperature of the water: ");
            float temperature = Convert.ToSingle(Console.ReadLine());

            // The variable 'state' is created
            string state = "";

            // The state of the water is found out
            if (temperature >= 100)
            {
                state = "gaseous";
            }

            else if (temperature >= 1)
            {
                state = "liquid";
            }

            else
            {
                state = "solid";
            }

            // The state and temperature is printed out to the user
            Console.Write($"The state of the water is {state} and the temperature is {(Math.Round(temperature, 2)).ToString("F2")}");
        }
    }
}
