using System;
using System.Collections.Generic;
using System.Text;

namespace Multifabriken
{
    public class Oatmilk
    {
        private string fat_content;
        private string liter_amount;

        HelpMethods help = new HelpMethods();

        public Oatmilk() { }

        public void ManageOrder()
        {
            Console.Write(" Fetthalt? ");
            fat_content = help.ReturnAnswer("fethalt"); // Using a method from HelpMethods to get correct inputted word
            Console.Write(" Liter mängd? ");
            liter_amount = help.ReturnAnswer("liter mängd"); // Using a method from HelpMethods to get correct inputted word

            help.Order("Havremjölk", "Fetthalt: " + fat_content, "Liter mängd: " + liter_amount); // Using method from HelpMethods to show order info
        }
    }
}
