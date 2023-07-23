using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QOAgeOfExploration



{
	public class Program
	{
        public static void Main(string[])
        {
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Welcome to Quantum Odyssey: Age of Exploration!");
            Console.WriteLine("Author: Jared Wile aka Siptah");
            Console.WriteLine("Version: 0.0.3");
            Console.WriteLine("Date: 07/22/2023");

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("This is a text-based adventure game where you explore the universe.");
            Console.WriteLine("You will be given a ship, and you will be able to explore the universe.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine("You are a part of a crew of astronauts who have been sent to explore the galaxy.");
            Console.WriteLine("The universe is a vast place, and you have been given the task of exploring it.");
            Console.WriteLine("You have been given a ship, and you are an experienced pilot.");
            Console.WriteLine("You have been dreaming of the day where you can explore the universe.");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("You are now in your ship, and you are ready to explore the universe.");
            Console.WriteLine("You see the stars passing by you as you wake up from hypersleep.");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("-------------------------------------");



            Console.WriteLine("Do you: ");
            Console.WriteLine("1. Go to the bridge");
            Console.WriteLine("2. Grab your weapon, and go to the bridge");


            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("You go to the bridge.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else if (Console.ReadLine() == "2")
            {
                Console.WriteLine("You grab your weapon, and go to the bridge..");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You do nothing.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Flying through hyperspace, you can hear the engines.");
            Console.WriteLine("You load up the holographic map of neighboring galaxies.");
            Console.WriteLine("Your crew assembles around the table, and you begin to discuss your plan.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("-------------------------------------");


            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Which planet would you like to go to? Says the ships AI.");
            Console.WriteLine("A holographic map appears in front of you, and you see 4 planets.");


            Console.WriteLine("1. Volaria");
            Console.WriteLine("2. Aquorin");
            Console.WriteLine("3. Pyrovia");
            Console.WriteLine("4. Luminara");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("You decide to go to Volaria.");
                Console.WriteLine("You arrive at Volaria, and you see a beautiful, lush, forested planet, surrounded by a series of 3 moons.");
                Console.WriteLine("You land your ship, and you begin to explore the planet.");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                Console.WriteLine("Do you: ");
                Console.WriteLine("1. Explore the forest");
                Console.WriteLine("2. Explore the ruins");
                Console.WriteLine("3. Explore the mountains");
                Console.WriteLine("4. Explore the ocean");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                Console.WriteLine("-------------------------------------");


                Console.WriteLine("-------------------------------------");


            }
            else if (Console.ReadLine() == "2")
            {
                Console.WriteLine("You decide to go to Aquorin.");
            }
            else if (Console.ReadLine() == "3")
            {
                Console.WriteLine("You decide to go to Pyrovia.");
            }
            else if (Console.ReadLine() == "4")
            {
                Console.WriteLine("You decide to go to Luminara.");
            }
            else
            {
                Console.WriteLine("You decide to go to Volaria.");

            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            Console.WriteLine("-------------------------------------");

        }
    }
}