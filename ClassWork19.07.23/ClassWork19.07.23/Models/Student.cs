using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork19._07._23.Models
{
    internal class Student
    {
        public string fullName;
        public int age;
        public string adress;

        public string GetFullData()
        {
            Book book = new();
            book.ShowAdvert();
            return $"Full name: {fullName}, Age: {age}, Adress: {adress}";
        }
    }
}
