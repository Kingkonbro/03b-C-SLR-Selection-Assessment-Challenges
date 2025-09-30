using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is prompted to enter the nitrate level
            Console.Write("Enter nitrate level: ");
            float nitrate = Convert.ToSingle(Console.ReadLine());

            string dose = "";
            if (nitrate > 10)
            {
                dose = "3ml";
            }

            else if (nitrate > 2.5)
            {
                dose = "2ml";
            }

            else if (nitrate > 1)
            {
                dose = "1ml";
            }

            else if (nitrate <= 1)
            {
                dose = "0.5ml";
            }

            Console.WriteLine($"The dose is: {dose}");
        }
    }
}
