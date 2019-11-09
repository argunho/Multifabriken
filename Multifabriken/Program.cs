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

            List<string> menu = new List<string> { "Bilar", "Godis", "Rör", "Havremjölk" };

            var run = true;

            while (run)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // text color
                Console.WriteLine("\n M U L T I F A B R I K E N\n");
                Console.ForegroundColor = ConsoleColor.Cyan; // text color
                Console.WriteLine(" PRODUKTLISTA");

                var ind = 1;
                foreach (var l in menu)
                {
                    if (ind == 1)
                        Console.WriteLine();

                    Console.WriteLine("\t" + ind + ". " + l);
                    ind += 1;
                }

                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Tryck nummer av Produktlista och sedan tryck Enter ...\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Ditt val: ");

                var number = 0;
                while (true)// while (int.TryParse(Console.ReadLine(), out casNum)
                {
                    if (int.TryParse(Console.ReadLine(), out number) && number > 0 && number < 5) break; // checking on the selected symbols, if this not int 
                    Console.ForegroundColor = ConsoleColor.Red; // change of color
                    Console.WriteLine(" Tryck rätt nummer av Produktlista ... ".ToUpper());
                    Console.Write(" ");
                }

                if (number > 0)
                {
                    choice = menu[number - 1].ToUpper();
                    Console.WriteLine(number);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White; // change of color
                    Console.Write("\n Ditt val är: ");
                    Console.ForegroundColor = ConsoleColor.Green; // change of color
                    Console.Write(choice);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White; // change of color
                    Console.WriteLine("\n\n Vi behöver veta lite mer information. Var vänlig svara på nedåstående frågorna.\n\n");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White; // change of color
                }

                switch (number)
                {
                    case 1:
                        cars.ManageOrder();
                        break;
                    case 2:
                        candy.ManageOrder();
                        break;
                    case 3:
                        pipe.ManageOrder();
                        break;
                    case 4:
                        milk.ManageOrder();
                        break;
                }

                var key = Console.ReadKey();
                if (key.Key != ConsoleKey.R)
                {
                    Environment.Exit(0);
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
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