using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifabriken
{
    class Oatmilk
    {

        private string fat_content;
        private string liter_amount;

        HelpMethods help = new HelpMethods();

        public Oatmilk(){}

        public void ManageOrder()
        {
            Console.Write(" Fetthalt? ");
            fat_content = help.ReturnName("fethalt");
            Console.Write(" Liter mängd? ");
            liter_amount = help.ReturnName("liter mängd");

            help.Order("Havremjölk", "Fetthalt: " + fat_content, "Liter mängd: " + liter_amount);
        }
    }
}
