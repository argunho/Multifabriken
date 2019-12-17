using System;
using System.Collections.Generic;
using System.Text;

namespace Multifabriken
{
    public class Cars
    {
        private string model;
        private string reg_number;
        private string color;

        HelpMethods help = new HelpMethods();

        public Cars() { }

        public void ManageOrder()
        {
            Console.Write(" Billmärke? ");
            model = help.ReturnAnswer("bilmärke"); // Using a method from HelpMethods to get correct inputted word
            Console.Write(" Registreringsnummer? ");
            reg_number = help.ReturnAnswer("Registernummer"); // Using a method from HelpMethods to get correct inputted word
            Console.Write(" Färg? ");
            color = help.ReturnAnswer("color"); // Using a method from HelpMethods to get correct inputted word

            help.Order("Bilen", "Bilmärke: " + model, "Registernummer: " + reg_number, "Färg: " + color); // Using method from HelpMethods to show order info
        }
    }
}
