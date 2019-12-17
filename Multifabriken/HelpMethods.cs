using System;
using System.Collections.Generic;
using System.Text;

namespace Multifabriken
{
    public class HelpMethods
    {
        public HelpMethods() { }

        // Method to return answer
        public string ReturnAnswer(string str)
        {
            var input = String.Empty;

            while (true) // To check input characters
            {
                input = Console.ReadLine();
                if (input.Length > 1) break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Ursäkta, vi behöver veta korrekta " + str + "  ...."); // If wrong input, show error message
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Var vänlig prova igen!");
            }
            return input.ToString(); // Return correct inputted word
        }

        // Return order info
        public void Order(string str01, string str02, string str03, string str04 = null)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Tack för beställning!\n\n".ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + str01.ToUpper());
            Console.WriteLine(" " + str02);
            Console.WriteLine(" " + str03);
            if (str04 != null)
                Console.WriteLine(" " + str04);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\n För att återgå till Menyn, tryck R. För att avsluta tryck på någon knapp ...".ToUpper());// Displaying message
        }
    }
}
