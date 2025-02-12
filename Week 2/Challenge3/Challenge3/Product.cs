using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Product
    {
        public int ID;
        public string pname;
        public string Quantity;
        public float Pprice;
        public string pcategory;
        public string pCountry;
        public Product(int id, string name, string quantity, string category, string country, float price)
        {
            ID = id;
            pname = name;
            Quantity = quantity;
            pcategory = category;
            pCountry = country;
            Pprice = price;
        }
        public Product(string name, string quantity, string category, string country, float price)
        {
            
            pname = name;
            Quantity = quantity;
            pcategory = category;
            pCountry = country;
            Pprice = price;
        }
        public void showproducts()
        {
            Console.WriteLine($"The productID is {ID} , ProductName is {pname} , Quantity is {Quantity} , Category is {pcategory} , Country is {pCountry} , Price is {Pprice}");
        }
    }
}
