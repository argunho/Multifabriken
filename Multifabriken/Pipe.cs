using System;
using System.Collections.Generic;
using System.Text;

namespace Multifabriken
{
    public class Pipe
    {
        private string diameter;
        private string length;

        HelpMethods help = new HelpMethods();

        public Pipe() { }

        public void ManageOrder()
        {
            Console.Write(" Diameter? ");
            diameter = help.ReturnAnswer("diameter"); // Using a method from HelpMethods to get correct inputted word
            Console.Write(" Längd? ");
            length = help.ReturnAnswer("längd"); // Using a method from HelpMethods to get correct inputted word

            help.Order("Rör", "Diameter: " + diameter, "Längd: " + length); // Using method from HelpMethods to show order info
        }
    }
}
