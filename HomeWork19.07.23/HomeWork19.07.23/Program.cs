using HomeWork19._07._23;
using HomeWork19._07._23.Models;

//Console.WriteLine("Username daxil et:");
//string username = Console.ReadLine();
//Console.WriteLine("Passwordu daxil et :");
//string password = Console.ReadLine();
//Console.WriteLine("-------");
//Account account = new Account();
//Console.WriteLine(account.Login(username,password));

Console.WriteLine("Number 1:");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Number 2:");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

Calculator calculator = new Calculator(num1,num2);
Console.WriteLine("----------");
Console.WriteLine("Summary :" + calculator.Sum());
Console.WriteLine("Subtraction :" + calculator.Sub());
Console.WriteLine("Multiplication :" + calculator.Multiply());
Console.WriteLine("Division :" + calculator.Division());
