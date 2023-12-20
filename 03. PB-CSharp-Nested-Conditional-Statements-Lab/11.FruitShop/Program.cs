string plant = Console.ReadLine();
string dayOfWeek  = Console.ReadLine(); 
double amount = double.Parse(Console.ReadLine());

bool IsWorkingDay = dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wendesday" 
    || dayOfWeek == "Thursday" || dayOfWeek == "Friday";


switch (plant)
{
    case "banana":
        if (IsWorkingDay)
        {
            Console.WriteLine($"{amount * 2.50:f2}");
        }
        else
        {
            Console.WriteLine($"{amount * 2.70:f2}");
        }
        break;
}



//if (plant == "banana")
//{

//    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday"
//        || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
//    {
//        Console.WriteLine($"{amount * 2.50:f2}");
//    }
//    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
//    {
//        Console.WriteLine($"{amount * 2.70:f2}");
//    }
//    else { Console.WriteLine("error");};
//}
//else if (plant == "apple")
//{

//    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday"
//        || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
//    {
//        Console.WriteLine($"{amount * 1.20:f2}");
//    }
//    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
//    {
//        Console.WriteLine($"{amount * 1.25:f2}");
//    }
//    else { Console.WriteLine("error");};
//}
//else if (plant == "orange")
//{

//    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday"
//        || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
//    {
//        Console.WriteLine($"{amount * 0.85:f2}");
//    }
//    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
//    {
//        Console.WriteLine($"{amount * 0.90:f2}");
//    }
//    else { Console.WriteLine("error");};
//}
//else if (plant == "grapefruit")
//{

//    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday"
//        || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
//    {
//        Console.WriteLine($"{amount * 0.45:f2}");
//    }
//    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
//    {
//        Console.WriteLine($"{amount * 1.60:f2}");
//    }
//    else { Console.WriteLine("error");};
//}
//else if (plant == "kiwi")
//{

//    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday"
//        || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
//    {
//        Console.WriteLine($"{amount * 2.70:f2}");
//    }
//    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
//    {
//        Console.WriteLine($"{amount * 3.00:f2}");
//    }
//    else { Console.WriteLine("error");};
//}
//else if (plant == "pineapple")
//{

//    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday"
//        || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
//    {
//        Console.WriteLine($"{amount * 5.50:f2}");
//    }
//    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
//    {
//        Console.WriteLine($"{amount * 5.60:f2}");
//    }
//    else { Console.WriteLine("error");};
//}
//else if (plant == "grapes")
//{

//    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday"
//        || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
//    {
//        Console.WriteLine($"{amount * 3.85:f2}");
//    }
//    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
//    {
//        Console.WriteLine($"{amount * 4.20:f2}");
//    }
//    else { Console.WriteLine("error");};
//}
//else
//{
//    Console.WriteLine("error");
//}
