using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = String.Empty;
            Cars cars = new Cars();
            Candy candy = new Candy();
            Pipe pipe = new Pipe();
            Oatmilk milk = new Oatmilk();
            HelpMethods help = new HelpMethods();

            List<string> menu = new List<string> { "Bilar", "Godis", "Rör", "Havremjölk" }; // Productlist

            var run = true;

            while (run) // Lopp
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // text color
                Console.WriteLine("\n M U L T I F A B R I K E N\n"); // Projekt namn
                Console.ForegroundColor = ConsoleColor.Cyan; // text color
                Console.WriteLine(" PRODUKTLISTA");

                var ind = 1;
                foreach (var l in menu) // Loop to create productslista
                {
                    if (ind == 1)
                        Console.WriteLine();

                    Console.WriteLine("\t" + ind + ". " + l);
                    ind += 1;
                }

                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Tryck nummer av Produktlista och sedan tryck Enter ...\n\n"); // Message for user
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Ditt val: "); // Plats for input

                var number = 0;
                while (true)// while (int.TryParse(Console.ReadLine(), out casNum)
                {
                    if (int.TryParse(Console.ReadLine(), out number) && number > 0 && number < 5) break; // checking on the selected
                    Console.ForegroundColor = ConsoleColor.Red; // change of color
                    Console.WriteLine(" Tryck rätt nummer av Produktlista ... ".ToUpper()); // Error message
                    Console.Write(" ");
                }

                if (number > 0)
                {
                    choice = menu[number - 1].ToUpper(); // Name of the chosen product
                    Console.WriteLine(number);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White; // change of color
                    Console.Write("\n Ditt val är: "); // Message about the chosen product
                    Console.ForegroundColor = ConsoleColor.Green; // change of color
                    Console.Write(choice); // Print out name of product
                    Console.BackgroundColor = ConsoleColor.Blue; // Text background
                    Console.ForegroundColor = ConsoleColor.White; // change of color
                    Console.WriteLine("\n\n Vi behöver veta lite mer information. Var vänlig svara på nedåstående frågorna.\n\n"); // Message to user

                    Console.BackgroundColor = ConsoleColor.Black; // Text background
                    Console.ForegroundColor = ConsoleColor.White; // change of color
                }

                switch (number) // Check of user's choice and run this method which is will be called
                {
                    case 1:
                        cars.ManageOrder(); // Here start run class Cars
                        break;
                    case 2:
                        candy.ManageOrder(); // Here start run class Candy
                        break;
                    case 3:
                        pipe.ManageOrder(); // Here start run class Pipe
                        break;
                    case 4:
                        milk.ManageOrder(); // Here start run class Oatmilk
                        break;
                }

                // Runs after when order was finished 
                var key = Console.ReadKey(); // Check of pressed key 
                if (key.Key != ConsoleKey.R) // If pressed any key not R, console will be closed
                {
                    Environment.Exit(0); // Command to close console
                }

                Console.BackgroundColor = ConsoleColor.Black; // If user's choice was return to Product's list, background will be changed to black color
                Console.Clear(); // Clear all text before return to start
            }

            Console.Read();
        }
    }
}
//if (Console.ReadLine() == "y")
//{
//    //var fileName = Assembly.GetExecutingAssembly().Location;
//    //System.Diagnostics.Process.Start(fileName);

//    //Start process, friendly name is something like MyApp.exe (from current bin directory)
//    System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

//    //Close the current process
//    
//}