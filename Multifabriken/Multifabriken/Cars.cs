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
            model = help.ReturnName("bilmärke");
            Console.Write(" Registreringsnummer? ");
            reg_number = help.ReturnName("registernummer");
            Console.Write(" Färg? ");
            color = help.ReturnName("color");

            help.Order("Bilen", "Bilmärke: " + model, "registernummer: " + reg_number, "Färg: " + color);
        }
    }
}
