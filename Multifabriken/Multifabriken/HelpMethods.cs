using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifabriken
{
    class HelpMethods
    {
        public HelpMethods()
        {

        }

        public string ReturnName(string str)
        {
            var input = String.Empty;

            while (true)
            {
                input = Console.ReadLine();
                if (input.Length > 1) break;
                ErrorMessage(" Ursäkta, vi behöver veta korrekta " + str + "  ....");
            }
            return input.ToString();
        }

        public void ErrorMessage(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
        }

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
            Console.WriteLine("\n\n För att återgå till Menun, tryck R. För att avsluta tryck på någon knapp ...".ToUpper());
        }
    }
}
