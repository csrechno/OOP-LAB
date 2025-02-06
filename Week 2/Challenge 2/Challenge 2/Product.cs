using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Product
    {
        public int ID;
        public string pname;
        public string BrandName;
        public float Pprice;
        public string pcategory;
        public string pCountry;
        public Product(int id, string name, string brandname, string category ,string country, float price) 
        { 
            ID = id;
            pname = name;
            BrandName = brandname;
            pcategory = category;
            pCountry = country;
            Pprice = price;
        }
        public void  showproducts()
        {
            Console.WriteLine($"The productID is {ID} , ProductName is {pname} , BrandName is {BrandName} , Category is {pcategory} , Country is {pCountry} , Price is {Pprice}");
        }
    }
}
