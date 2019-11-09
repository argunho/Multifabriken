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

        public void ManageOrder()
        {
            Console.Write(" Smak? ");
            taste = help.ReturnName("smak");
            Console.Write(" Antal? ");
            count = help.ReturnName("antal");

            help.Order("Godis", "Smak: " + taste, "Antal: " + count);
        }


    }
}
