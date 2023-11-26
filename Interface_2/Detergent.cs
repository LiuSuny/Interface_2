using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Detergent : HouseholdChemical
    {
        private string cleaningType;

        public string CleaningType
        {
            get { return cleaningType; }
            set { cleaningType = value; }
        }

        public override void Receipt()
        {
            // Call the base class Receipt method to handle common receipt logic
            base.Receipt();

            Console.WriteLine("Enter the cleaning type of the detergent:");
            cleaningType = Console.ReadLine();

            Console.WriteLine($"Detergent receipt successful. Cleaning Type: {cleaningType}");
        }
        //Note we can realize other method like printdata, sales etc using the same method 
    }
}
