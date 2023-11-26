using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Meat : FoodProducts
    {
        private string cut;

        public string Cut
        {
            get { return cut; }
            set { cut = value; }
        }

        public override void Receipt()
        {
            // Call the base class Receipt method to handle common receipt logic
            base.Receipt();

            Console.WriteLine("Enter the cut of the meat:");
            cut = Console.ReadLine();

            Console.WriteLine($"Meat receipt successful. Cut: {cut}");
        }

    }
}
