using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user enters their name
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            // The players name is initiated and set to 100
            int health = 100;

            // The user is prompted to enter a direction
            Console.WriteLine("Enter a direction (left or right):");
            string direction = Console.ReadLine();

            // The users next move are presented
            if (direction == "left")
            {
                // Users decision are asked
                Console.WriteLine("Do you want to fight or flee?");
                string fightOrFlee = Console.ReadLine();

                // Depending on what the user picks their fate is found out
                if (fightOrFlee == "fight")
                {
                    health = health - 10;
                    Console.WriteLine($"You fought and won! Your health is now {health}");
                }

                if (fightOrFlee == "flee")
                {
                    health = health - 20;
                    Console.WriteLine($"You fled successfully! While catching onto some branches. Your health is now {health}");
                }
            }

            if (direction == "right")
            {   
                // Users next decision is asked
                Console.WriteLine("You have found a treasure chest.Do you open it or ignore it?");
                string openOrIgnore = Console.ReadLine();

                // The users fate is found out
                if (openOrIgnore == "open") 
                {
                    health = health + 20;
                    Console.WriteLine($"You have found a magical potion! Your health is now {health}");
                }

                if (openOrIgnore == "ignore")
                {
                    Console.WriteLine($"You moved on. Your health remained at {health}");
                }
            }
        }
    }
}
