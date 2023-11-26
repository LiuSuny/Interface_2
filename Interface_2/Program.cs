//#define INTERFACE_CLAS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Interface_2
{
#if  INTERFACE_CLAS
    interface IWorker
    {
        bool IsWorker { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorker> List_wor { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }
    abstract class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $" ID: {Id} Surname: {LastName}\nFirstName:{FirstName}\n";
        }
    }
    abstract class Employee : Human
    {
        public double Salary { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nPosition:{Position}  Salary: {Salary} $";
        }
    }
    class Director : Employee, IManager
    {
        public List<IWorker> List_wor { get; set; }
        public void Control()
        {
            WriteLine("Control work");
        }

        public void MakeBudget()
        {
            WriteLine("Make budget");
        }

        public void Organize()
        {
            WriteLine("Organize work");
        }
    }

    class Cashier : Employee, IWorker
    {
        bool isWorker = true;
        public bool IsWorker { get { return isWorker; } }

        public string Work()
        {
            return $"Recieve payment for goods";
        }
    }
    class Storekeeper : Employee, IWorker
    {
        bool isWorker = true;
        public bool IsWorker { get { return isWorker; } }

        public string Work()
        {
            return $"Make acct for goods and store products";
        }
    }
    class Seller : Employee, IWorker
    {
        bool isWorker = true;
        public bool IsWorker { get { return isWorker; } }

        public string Work()
        {
            return $"Sells Goods";
        }
    } 
#endif

    class Program
    {
        static void Main(string[] args)
        {
#if INTERFACE_CLAS
            //Director boss = new Director { Id = 1, LastName = "John", FirstName = "Jane", Position = "Director", Salary = 9073 };


            //IWorker seller = new Seller
            //{
            //    Id = 2,
            //    LastName = "John",
            //    FirstName = "Jane",
            //    Position = "Director",
            //    Salary = 11073
            //};



            //boss.List_wor = new List<IWorker>
            //{
            //    seller, new Cashier
            //    {
            //        Id = 3, 
            //        LastName = "LC", 
            //        FirstName = "FC", 
            //        Position = "Cashier", 
            //        Salary = 8000
            //    },
            //    new Storekeeper
            //    {
            //        Id = 4, 
            //        LastName = "LSt", 
            //        FirstName = "FSt", 
            //        Position = "Storekeeper", 
            //        Salary = 10000
            //    }
            //};

            ////is as 

            //if (seller is Employee) WriteLine($"Salary :{(seller as Employee).Salary}");
            //WriteLine(boss);
            //if (boss is IManager) boss.MakeBudget();
            //foreach (IWorker item in boss.List_wor)
            //{
            //    WriteLine(item);
            //    if (item.IsWorker) WriteLine(item.Work());
            //    WriteLine();
            //}

#endif


            IProducts goods;

            while (true)
            {
                Console.WriteLine("Select the type of goods:");
                Console.WriteLine("1. Food Product");
                Console.WriteLine("2. Household Chemical");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        goods = new FoodProducts();
                        productDataPerformance(goods);
                        break;
                    case 2:
                        goods = new HouseholdChemical();
                        productDataPerformance(goods);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void productDataPerformance(IProducts goods)
        {
            while (true)
            {
                Console.WriteLine("Select operation:");
                Console.WriteLine("1. Receipt");
                Console.WriteLine("2. Sale");
                Console.WriteLine("3. Write-off");
                Console.WriteLine("4. Print Data");
                Console.WriteLine("5. Back to main menu");

                int operationChoice = int.Parse(Console.ReadLine());

                switch (operationChoice)
                {
                    case 1:
                        goods.Receipt();
                        break;
                    case 2:
                        goods.Sale();
                        break;
                    case 3:
                        goods.WriteOff();
                        break;
                    case 4:
                        goods.PrintData();
                        break;
                    case 5:
                        return; // Exit the loop and go back to the main menu
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
