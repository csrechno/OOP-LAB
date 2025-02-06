using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    { static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            int option = menu();
            while (option != 4)
            {
                switch (option)
                {
                        case 1:
                        string result = addproducts();
                        Console.WriteLine(result);
                        break;
                        case 2:
                            showproducts();
                         break;
                        case 3:
                        totalPrice();
                        break;
                        default:
                        Console.WriteLine("Exiting the program");
                        break;

                }
                Console.ReadKey();
                option = menu();
            }
        }
        
        static int menu()
        {    Console.Clear();
            Console.WriteLine("1-Add Products");
            Console.WriteLine("2-Show Products");
            Console.WriteLine("3-Total Store Worth");
            Console.WriteLine("4-Exit");
            Console.WriteLine("Enter a option (1-4)");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static public string addproducts()
        {
            int ID;
            float price; 
            string Category, BrandName, Country, name;
            Console.WriteLine("Enter product ID:");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter product brand:");
            BrandName = Console.ReadLine();
            Console.WriteLine("Enter product category:");
            Category = Console.ReadLine();  
            Console.WriteLine("Enter product Country:");
            Country= Console.ReadLine();
            Console.WriteLine("Enter product price:");
            price = float.Parse(Console.ReadLine());
            Product prod = new Product(ID,name,BrandName,Category,Country,price);
             products.Add(prod);
            return "Product added successfully:";
        }
        static public void showproducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products found:");
            }
            else
            {
                foreach (Product pro in products)
                { 
                    pro.showproducts();
                }
            }
        }
        static void totalPrice()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No product found:");
            }
            else
            {
                double worth = 0;
                foreach(Product pro in products)
                {
                    worth = worth+pro.Pprice;
                }
                Console.WriteLine($"The price of all products is {worth}");
            }
            
        }
    }
}
