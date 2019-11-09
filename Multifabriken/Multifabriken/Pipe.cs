using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifabriken
{
    class Pipe
    {
        private string diameter;
        private string length;

        HelpMethods help = new HelpMethods();

        public Pipe(){}

        public void ManageOrder()
        {
            Console.Write(" Diameter? ");
            diameter = help.ReturnName("diameter");
            Console.Write(" Längd? ");
            length = help.ReturnName("längd");

            help.Order("Rör", "Diameter: " + diameter, "Längd: " + length);
        }
    }
}
