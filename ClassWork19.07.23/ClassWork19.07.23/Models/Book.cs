using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork19._07._23.Models
{
    internal class Book
    {
        public string name;
        public string author;
        public int pageCount;
        
        public void ShowAdvert()
        {
            string a = "Welcome";
            int b = 5;
            Console.WriteLine("Advertisment,"+a+b);
        }
    }
}
