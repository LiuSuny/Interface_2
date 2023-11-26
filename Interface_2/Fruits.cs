using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Fruits : FoodProducts
    {
        private string variety;

        public string Variety
        {
            get { return variety; }
            set { variety = value; }
        }

        public override void Receipt()
        {
            // Call the base class Receipt method to handle common receipt logic
            base.Receipt();

            Console.WriteLine("Enter the variety of the fruit:");
            variety = Console.ReadLine();

            Console.WriteLine($"Fruit receipt successful. Variety: {variety}");
        }
    }
}
