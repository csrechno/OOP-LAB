using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {    
        static List<Signin> stu = new List<Signin>();
        static List<Product> products = new List<Product>();
       static int ID;
        static void Main(string[] args)
        {
            string result;
            int choice = Menu();
            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        string password = Console.ReadLine();
                         string role = Sign(name, password);
                        if (role == "Admin" || role == "admin")
                        {

                            productmanage();
                        }
                        else if (role == "user" || role == "User")
                        {
                            Console.WriteLine("Welcome to User Menu:");
                        }
                        break;
                    case 2:
                        result = signup();
                        Console.WriteLine(result);
                        break;

                }
                Console.ReadKey();
                choice = Menu();
            }

        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1-Sign in to your account");
            Console.WriteLine("2-Sign up to your account");
            Console.WriteLine("3-Exit the program");

            Console.WriteLine("Enter option (1-3)");
            int option = int.Parse(Console.ReadLine());

            return option;
        }
        static int AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to admin Menu:");
            Console.WriteLine("1- Add New Products" );
            Console.WriteLine("2- Update Products");
            Console.WriteLine("3- Remove Products");
            Console.WriteLine("4- View Product Information");
            Console.WriteLine("5- Exit the Program");
           
            Console.WriteLine("Enter Option: ");
            int option = int.Parse(Console.ReadLine());
            return option ;
           

        }
        static void productmanage() 
        {
            string result;
            int Choice = AdminMenu();
            while (Choice != 5)
            {
                switch (Choice)
                {
                    case 1:
                        result = addproducts();
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = updateProducts();
                        Console.WriteLine(result);
                        break;
                    case 3:

                        break;
                    case 4:
                        ShowProducts();
                        break;
                    default:
                        Console.WriteLine("Exiting the program:");
                        break;

                }
                Console.ReadKey();
                Choice = AdminMenu();
            }
        }
        static string signup()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your role:");
            string role = Console.ReadLine();
            bool isDuplicate = false;
           
            foreach (Signin p in stu)
            {
                if ((p.Username == name))
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
            {
                return $"Error: Username already exists!";
            }
            Signin page = new Signin(name, password, role);
            stu.Add(page);
            return $"The {name} added sucessfully:";
        }
        static string Sign(string username , string password)
        {
            if (stu.Count == 0)
            {
                Console.WriteLine("No user found:");
            }
            else
            {
                foreach (Signin page in stu) 
                { 
                    if((page.Username == username) && (page.Password == password))
                    {
                        return page.Role;
                    }
                    else
                    {
                        Console.WriteLine("Wrong credentials:");
                        Console.WriteLine("Please Enter correct Credentials:");
                    }                
                }
               
            }
            return "Undefined";
        }
        static string addproducts()
        {
             int Id;
            float price;
            string Category, Quantity, Country, name;

            bool isDuplicate = false;
            Console.WriteLine("Enter product ID:");
            Id = int.Parse(Console.ReadLine());
            foreach (Product p in products)
            {
                if (p.ID == Id)
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
            {
                return $"Error: Product with ID {Id} already exists!";
            }
            Console.WriteLine("Enter product name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter product Quantity:");
            Quantity = Console.ReadLine();
            Console.WriteLine("Enter product category:");
            Category = Console.ReadLine();
            Console.WriteLine("Enter product Country:");
            Country = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            price = float.Parse(Console.ReadLine());
            Product product = new Product(Id, name, Quantity, Category, Country, price);
            products.Add(product);
            
            
            return $"Product {Id} added successfully!";
        }
      
        static string updateProducts()
        {
            int Id;
            
            Console.WriteLine("Enter product ID:");
            Id = int.Parse(Console.ReadLine());
            if( products.Count == 0)
            {
                Console.WriteLine("No Products Found:");
            }
            else
            {
                foreach (Product product in products)
                {
                    if (product.ID == Id)
                    {
                        Console.WriteLine("Enter product updated name:");
                        product.pname = Console.ReadLine();
                        Console.WriteLine("Enter product updated Quantity:");
                        product.Quantity = Console.ReadLine();
                        Console.WriteLine("Enter product updated category:");
                        product.pcategory = Console.ReadLine();
                        Console.WriteLine("Enter product  updated Country:");
                        product.pCountry = Console.ReadLine();
                        Console.WriteLine("Enter product  updated price:");
                        product.Pprice = float.Parse(Console.ReadLine());

                        return "Products Updated Successfully:";
                    }
                    else
                    {
                        Console.WriteLine("No Product Id found:");
                    }
                }
            }
            return ""; 
        }
        static void ShowProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No Products Found:");

            }
            else
            {
                foreach (Product product in products)
                {
                  product.showproducts();
                }
            }
        }
    }
}
