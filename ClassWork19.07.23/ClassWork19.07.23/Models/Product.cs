using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork19._07._23.Models
{
    internal class Product
    {
        public int id;
        public string name;
        public decimal price;
        public DateTime CreatdDate;

        public Product()
        {
            Console.WriteLine("Welcome");
        }

        public Product(string text):this(DateTime.Now)
        {
            Console.WriteLine("This is my text :"+text);
        }

        public Product(DateTime date):this(10,15)
        {
            Console.WriteLine("This is my date"+date);
        }

        public Product(int a,int b):this()
        {
            Console.WriteLine(a+b);
        }
    }
}
