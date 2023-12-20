int hours = int.Parse(Console.ReadLine());
string weekDay = Console.ReadLine();


if (weekDay != "Sunday")
{
    if (hours >= 10 && hours <= 18)
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }
}
else if (weekDay == "Sunday")
{
    Console.WriteLine("closed");
}


