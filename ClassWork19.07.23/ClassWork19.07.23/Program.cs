using ClassWork19._07._23;
using ClassWork19._07._23.Models;

//Student stu1 = new()
//{
//    fullName = "Cahangir Axundov",
//    age = 20,
//    adress = "Suraxani"
//};
//Console.WriteLine(stu1.GetFullData());

//static void GetFullDatas()
//{
//    Student stu1 = new()
//    {
//        fullName = "Cahangir Axundov",
//        age = 20,
//        adress = "Suraxani"
//    };
//    Console.WriteLine(stu1.GetFullData());

//}
//GetFullDatas();

//Employee employee = new();
//employee.Test();

//Student stu1 = new()
//{
//    fullName = "Cahangir Axundov",
//    age = 20,
//    adress = "Suraxani"
//};
//Console.WriteLine(stu1.GetFullData());

//var result = GetProductById(2);
//Console.WriteLine(result.name);

//var result = GetProductByName("Nokia 14");
//Console.WriteLine(result.price);

//static Product GetProductByName(string name)
//{
//    var dbProducts = GetAllProducts();

//    foreach (var item in dbProducts)
//    {
//        if (item.name == name)
//        {
//            return item;
//        }
//    }

//    return null;

//}

//static Product GetProductById(int id)
//{
//    var dbProducts = GetAllProducts();
//    foreach (var item in dbProducts)
//    {
//        if (item.id == id)
//        {
//            return item;
//        }
//    }

//    return null;
//}

//static Product[] GetAllProducts()
//{
//    Product pr1 = new()
//    {
//        id = 1,
//        name = "Iphone 14",
//        price = 3500,
//        CreatdDate = DateTime.Now
//    };

//    Product pr2 = new()
//    {
//        id = 2,
//        name = "Nokia 14",
//        price = 35,
//        CreatdDate = DateTime.Now
//    };

//    Product pr3 = new()
//    {
//        id = 3,
//        name = "Samsung 14",
//        price = 1500,
//        CreatdDate = DateTime.Now
//    };

//    Product[] products = { pr1, pr2, pr3 };

//    return products;
//}

//User user1 = new User("xayyam55");
//User user2 = new User();
//Console.WriteLine(user1.username);
//Console.WriteLine(user2.username);

//Calculator calculator = new(2, 5);
//calculator.Sum();


Product product = new("iphone");