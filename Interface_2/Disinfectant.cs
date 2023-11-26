using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Disinfectant : HouseholdChemical
    {
        private string targetSurface;

        public string TargetSurface
        {
            get { return targetSurface; }
            set { targetSurface = value; }
        }

        public override void Receipt()
        {
            // Call the base class Receipt method to handle common receipt logic
            base.Receipt();

            Console.WriteLine("Enter the target surface of the disinfectant:");
            targetSurface = Console.ReadLine();

            Console.WriteLine($"Disinfectant receipt successful. Target Surface: {targetSurface}");
        }

    }
}
