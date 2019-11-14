using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifabriken
{
    class Cars
    {
        private string model;
        private string reg_number;
        private string color;

        HelpMethods help = new HelpMethods();

        public Cars(){}

        public void ManageOrder()
        {
            Console.Write(" Billmärke? ");
            model = help.ReturnAnswer("bilmärke"); // Using a method from HelpMethods to get correct inputted word
            Console.Write(" Registreringsnummer? ");
            reg_number = help.ReturnAnswer("registernummer"); // Using a method from HelpMethods to get correct inputted word
            Console.Write(" Färg? ");
            color = help.ReturnAnswer("color"); // Using a method from HelpMethods to get correct inputted word

            help.Order("Bilen", "Bilmärke: " + model, "registernummer: " + reg_number, "Färg: " + color); // Using method from HelpMethods to show order info
        }
    }
}
