using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19._07._23
{
    internal class Calculator
    {
        public decimal number1;
        public decimal number2;

        public Calculator(decimal number1,decimal number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public decimal Sum()
        {
            return number1+number2;
        }

        public decimal Sub()
        {
            return number1-number2;
        }
        public decimal Multiply()
        {
            return number1*number2;
        }
        public decimal Division()
        {
            if (number2 == 0)
            {
                Console.WriteLine("Division:bolmek olmaz");
            }

            return number1 / number2;
        }


    }
}
