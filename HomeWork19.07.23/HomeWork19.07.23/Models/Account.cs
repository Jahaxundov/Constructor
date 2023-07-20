using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19._07._23.Models
{
    internal class Account
    {
        public string username;
        public string password;

        public Account()
        {
            this.username = "cavid123";
            this.password = "Cavid123";
        }

        public string Login(string username,string password)
        {
            if(this.username==username && this.password == password)
            {
                return "Giris ugurla tamamlandi";
            }
            return "Username ve ya password sehvdi";
        }
    }
}
