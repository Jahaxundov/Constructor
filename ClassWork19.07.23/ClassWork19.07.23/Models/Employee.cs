using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork19._07._23.Models
{
    internal class Employee
    {
        public string fullName;
        public int age;
        public string adress;
        public int salary;

        public void Test()
        {
            Book book = new();
            book.ShowAdvert();
            Console.WriteLine("Test");
        }
    }
}
