


using Methods;
using System.Drawing;
using System.Xml.Linq;

//Calculate();
//static void Calculate()
//{
//Calculator calculator=new Calculator();
//Console.WriteLine("Add first number:");
// Number1: string number1=Console.ReadLine();
//    int checkedNum1;
//    bool IsParseNum1 = int.TryParse(number1,out checkedNum1);
//    if (!IsParseNum1)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 1");
//        Console.ResetColor();
//        goto Number1;
//    }

//Console.WriteLine("Add operation:");
//string operation=Console.ReadLine();

//Console.WriteLine("Add second number:");
// Number2: string number2=Console.ReadLine();
//int checkedNum2;
//bool IsParseNum2 = int.TryParse(number2,out checkedNum2);
//    if(!IsParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format data");
//        Console.ResetColor();
//        goto Number2;
//    }
//    if (checkedNum2==0&& operation=="/")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please dont add )");
//        Console.ResetColor();
//        goto Number2;
//    }
//    var result=calculator.Calculation(checkedNum1,checkedNum2,operation);
////    Console.ForegroundColor = ConsoleColor.Green;
////    Console.WriteLine(result);
////    Console.ResetColor();
////}



//static Doctor[] GetDoctors()
//{
//  Doctor doctor1 = new Doctor
//    {
//        Name = "Memmed",
//        Surname = "Memmedli",
//        Addres = "Baku",
//        Birthday = new DateTime(2000, 10, 06)
//    };
//    Doctor doctor2 = new Doctor
//    {

//        Name = "Eli",
//        Surname = "Memmedli",
//        Addres = "Quba",
//        Birthday = new DateTime(1998, 10, 07)
//    };
//    Doctor doctor3 = new Doctor
//    {

//        Name = "Seide",
//        Surname = "Memmedli",
//        Addres = "Qusar",
//        Birthday = new DateTime(1996, 09, 07)
//    };
//    Doctor doctor4 = new Doctor
//    {
//        Name = "Zemine",
//        Surname = "Seyidli",
//        Addres = "Xetai",
//        Birthday = new DateTime(2023, 05, 07)

//    };
//    Doctor[] arr = { doctor1, doctor2, doctor3, doctor4 };
//    return arr;
//}

//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 15);
//GetDoctorsByBirthday(startDate, endDate);
//static void GetDoctorsByBirthday(DateTime start,DateTime end)
//{
//    Doctor[]arr=GetDoctors();
//    foreach (var item in arr)
//    {
//        if (item.Birthday>start && item.Birthday<end)
//        {
//          Console.WriteLine($"{item.Name}-{item.Surname}-{item.Addres}-{item.Birthday}");
//        }
//    }
//}


//static Order[] GetOrders()
//{
//    var order1 = new Order(new DateTime(2022, 12, 12), 500);
//    var order2 = new Order(new DateTime(2022, 12, 01), 400);
//    var order3 = new Order(new DateTime(2022, 12, 02), 1500);
//    var order4 = new Order(new DateTime(2023, 12, 07), 150);

//    return new Order[] { order1, order2, order3, order4 };

//}

//DateTime filteredDate = DateTime.Now.AddDays(1);
//double filteredPrice = 200;
//GetFilteredOrders(filteredDate, filteredPrice);
//static void GetFilteredOrders(DateTime date,double price)
//{
//    var orders = GetOrders();
//    foreach (var item in orders)
//    {
//        if (item.Price>price &&item.Date<=date)
//        {
//            Console.WriteLine($"{item.Date}:{item.Price}");
//        }
//    }
//}