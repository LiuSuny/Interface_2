using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Products : IProducts
    {
        private string name;
        private decimal price;
        private string productionTime;
        public decimal currentStock = 10;

        public string Name //call method property
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    Name = "No Name";
                    Console.WriteLine("Can't use numbers in name");
                }
                name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Price = 0;
                    Console.WriteLine("price can not be less than zero");
                }
                price = value;
            }
          
        }

        public string ProductionTime
        {
            get { return productionTime; }
            set {
                productionTime = value; }
        }

        
        public virtual void Receipt()
        { 
            Console.WriteLine("Enter the products Names ? ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the products price ? ");
            Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the production date ? ");
            ProductionTime = Console.ReadLine();
            Console.WriteLine("Enter the quantity for receipt:");
            decimal quantity = decimal.Parse(Console.ReadLine());

            // Perform the receipt operation
            // For simplicity, just increase the current stock by the received quantity
            currentStock += quantity;

            Console.WriteLine($"******Sale successful****** \nName of the products: {Name} \nPrice: {Price:c} \nProduction time: {ProductionTime} \n Current stock: {currentStock}");
        }

        public virtual void Sale()
        {
            Console.WriteLine("Enter the products sold Names? ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the products price sold? ");
            Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the production date ? ");
            ProductionTime = Console.ReadLine();
            Console.WriteLine("Enter the quantity for receipt:");
            decimal quantity = decimal.Parse(Console.ReadLine());
            
            // To realize our sold products we decrease the current stock by the sold quantity
            if (quantity <= currentStock)
            {
                currentStock -= quantity;
                Console.WriteLine($"******Sale successful****** \nName of the products: {Name} \nPrice: {Price:c} \nProduction time: {ProductionTime} \n Current stock: {currentStock}");
               
            }
            else
            {
                Console.WriteLine("Not enough stock for sale.");
            }
        }

        public virtual void WriteOff() { }
       
        public virtual void PrintData()
        {
            Console.WriteLine($"Name of the products: {Name} \nPrice: {Price:c} \nProduction time: {ProductionTime} \nCurrentStock: {currentStock}");
        }


    }
}
