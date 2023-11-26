using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class FoodProducts : Products
    {

        private string expirationDate;

        public string ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public override void Receipt()
        {
            
            base.Receipt();

            Console.WriteLine("Enter the expiration date for the food product:");
            expirationDate = Console.ReadLine();

            Console.WriteLine($"Food product receipt successful. Expiration date: {expirationDate}");
        }

        public override void Sale()
        {
            base.PrintData();
        }

        public override void WriteOff()
        {
            Console.WriteLine("Enter the quantity for write-off:");
            decimal quantity = decimal.Parse(Console.ReadLine());

            // Perform the write-off operation
            // For simplicity, just decrease the current stock by the written-off quantity
            if (quantity <= currentStock)
            {
                currentStock -= quantity;
                Console.WriteLine($"******Sale successful****** \nName of the products: {Name} \nPrice: {Price:c} \nProduction time: {ProductionTime} \n Current stock: {currentStock}");
            }
            else
            {
                Console.WriteLine("Not enough stock for write-off.");
            }
        }

        public override void PrintData()
        {
            base.PrintData(); 
            Console.WriteLine($"Expiration Date: {expirationDate}");
        }

    }
}
