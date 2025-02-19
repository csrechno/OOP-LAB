using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task_2
{
    internal class Program
    {
        static List<MEMBER>list = new List<MEMBER>();
        static void Main(string[] args)
        {
            int total_sale = 0;
            int option = Menu();
            while(option != 10)
            {

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the member: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter CNIC number of member: ");
                        long cnic = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your phone numberof your member: ");
                        string  phone = Console.ReadLine();
                        MEMBER p = new MEMBER(name, phone, cnic);
                        list.Add(p);
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the book.");
                        string book_name = Console.ReadLine();
                        Console.WriteLine("Enter the name of author: ");
                        string author_name = Console.ReadLine();
                        Console.WriteLine("Enter the name of the publisher: ");
                        string publihser = Console.ReadLine();
                        Console.WriteLine("Enter the ISBN of book: ");
                        int isbn = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ente the price of the book.");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the year of publication: ");
                        int year = int.Parse(Console.ReadLine());
                        MEMBER member = new MEMBER(book_name, author_name, publihser, isbn, price, year);
                        list.Add(member);
                        break;
                    case 3:
                        Console.WriteLine("Enter the title of the book: ");
                        string title = Console.ReadLine();
                        foreach(MEMBER m in list)
                        {
                            if (m.Book_Name == title)
                            {
                                Console.WriteLine($"The Name of book : {m.Book_Name} ");
                                Console.WriteLine($"Author of the book: {m.Author_Name}");
                                Console.WriteLine($"name of the publisher: {m.Publisher_name}");
                                Console.WriteLine($"ISBN number of the book: {m.ISBN}");
                                Console.WriteLine($"Price of the book: {m.Price}");
                                Console.WriteLine($"Year of publication: {m.Year}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the ISBN number of the book: ");
                        isbn = int.Parse(Console.ReadLine());
                        foreach (MEMBER m in list)
                        {
                            if (m.ISBN == isbn)
                            {
                                Console.WriteLine($"Name of book : {m.Book_Name} ");
                                Console.WriteLine($"Author of the book: {m.Author_Name}");
                                Console.WriteLine($"name of the publisher: {m.Publisher_name}");
                                Console.WriteLine($"Price of the book: {m.Price}");
                                Console.WriteLine($"Year of publication: {m.Year}");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the name: ");
                        name = Console.ReadLine();
                        foreach (MEMBER m in list)
                        {
                            if(m.Name == name)
                            {
                                Console.WriteLine($"Phone : {m.Phone} ");
                                Console.WriteLine($"CNIC : {m.CNIC}");
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("Enter the name of member you update: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the updated phone number: ");
                        phone = Console.ReadLine();
                        Console.WriteLine("Enter the updated CNIC: ");
                        cnic = long.Parse(Console.ReadLine());
                        foreach (MEMBER m in list)
                        {
                            if(m.Name == name)
                            {
                                m.Phone = phone;
                                m.CNIC = cnic;
                            }
                        }
                        break;
                    case 7:
                        int PRICE =0;
                        int disc_price;
                        int price_after;
                        Console.WriteLine("Enter the name: ");
                        string nam = Console.ReadLine();
                        bool found = false;
                        foreach (MEMBER m in list)
                        {
                            if (m.Name == nam)
                            {
                                Console.WriteLine("Member found");
                                found = true;
                                break;
                            }
                        }
                        if(!found)
                        {
                            Console.WriteLine("Member not found.");
                        }
                        Console.ReadKey();
                        Console.WriteLine("Enter the tile of the book you want to purchase: ");
                        title = Console.ReadLine();
                        Console.WriteLine("Enter the quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        bool bookfound = false;
                        foreach(MEMBER m in list)
                        {
                            if(m.Book_Name == title)
                            {
                                PRICE = m.Price;
                                total_sale += (quantity*PRICE);
                                bookfound = true;
                                break;
                            }
                        }
                        if (!bookfound)
                        {
                            Console.WriteLine("No book found.");
                        }
                        else
                        {
                            if (found)
                            {
                                disc_price = quantity * (PRICE * 5 / 100);
                                price_after = (quantity * PRICE) - disc_price;
                                
                                Console.WriteLine($"Since you were a member , you are given a discount {disc_price}");
                                Console.WriteLine($"You are charged only: {price_after}");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"Since , you are not a member , you have to pay full fee of : {PRICE}");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine($"Total sales came from books: {total_sale}");
                        break;
                    case 9:
                        int product;
                        foreach (MEMBER m in list)
                        {
                            Console.WriteLine($"Name : {m.Name} , CNIC : {m.CNIC} , Phone : {m.Phone}");

                        }
                        product = 10*list.Count;
                        Console.WriteLine($"total membership fee collected: {product}");
                        break;
                }
                Console.ReadKey();
                option = Menu();
            }
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add Member");
            Console.WriteLine("2.Add a book.");
            Console.WriteLine("3.Search the specific book by its specific title.");
            Console.WriteLine("4.Search the specific  book by its specific ISBN.");
            Console.WriteLine("5.Search a member by its name.");
            Console.WriteLine("6.Update member information.");
            Console.WriteLine("7.Purchase a book.");
            Console.WriteLine("8.Display total sales.");
            Console.WriteLine("9.Display total members registered.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static bool membership(string name)
        {
            bool found= false;
            foreach (MEMBER m in list)
            {
                if (m.Name == name)
                {
                    Console.WriteLine("member found");
                    found = true;
                    break;
                }
            }            
            return false;
        }
    }
}
