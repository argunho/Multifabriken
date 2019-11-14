using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifabriken
{
    class Candy
    {
        private string taste;
        private string count;

        HelpMethods help = new HelpMethods();

        public Candy(){}

        public void ManageOrder() // If user's choise is Candy, this method runs i Program class
        {
            Console.Write(" Smak? "); // Ask about taste
            taste = help.ReturnAnswer("smak"); // Using a method from HelpMethods to get correct inputted word
            Console.Write(" Antal? ");
            count = help.ReturnAnswer("antal"); // Using a method from HelpMethods to get correct inputted word

            help.Order("Godis", "Smak: " + taste, "Antal: " + count); // Using method from HelpMethods to show order info
        }


    }
}
