using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Cleaner : HouseholdChemical
    {
        private string cleaningPurpose;

        public string CleaningPurpose
        {
            get { return cleaningPurpose; }
            set { cleaningPurpose = value; }
        }

        public override void Receipt()
        {
            // Call the base class Receipt method to handle common receipt logic
            base.Receipt();

            Console.WriteLine("Enter the cleaning purpose of the cleaner:");
            cleaningPurpose = Console.ReadLine();

            Console.WriteLine($"Cleaner receipt successful. Cleaning Purpose: {cleaningPurpose}");
        }

    }

}
