using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork19._07._23
{
    internal class Calculator
    {
        public int num1;
        public int num2;

        public Calculator(int a,int b)
        {
            num1 = a;
            num2 = b;
        }

        public void Sum()
        {
            int sum = 0;
            for (int i = num1; i < num2; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of nums :"+ sum);
        }
    }
}
