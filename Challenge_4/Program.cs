using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is prompted to enter the length and width of the rectangle
            Console.Write("Enter the length of the rectangle: ");
            float length = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            float width = Convert.ToSingle(Console.ReadLine());

            // area of rectangle is calculated
            double area = Math.Round(length * width, 2);

            // Check is shape is rectangle or square and print to user + print the area
            if (length == width)
            {
                Console.WriteLine($"This is square of area {area.ToString("F2")}");
            }

            else
            {
                Console.WriteLine($"This is a rectangle of area {area.ToString("F2")}");
            }


        }
    }
}
