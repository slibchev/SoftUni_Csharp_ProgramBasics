int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

double minuteSum = minutes +15;
double hoursNew = 0;
double minutesLeft = minuteSum % 60;

if (minuteSum >= 60)
{
    hoursNew++;
    if (hoursNew + hours > 23 && minutesLeft < 10)
    {
        hoursNew = 0;
        Console.WriteLine($"{hoursNew}:0{minutesLeft}");
    }
    else if (hoursNew + hours > 23 && minutesLeft > 10)
    {
        hoursNew = 0;
        Console.WriteLine($"{hoursNew}:{minutesLeft}");
    }
    else if (minuteSum < 10 || minutesLeft <10)
    {
        Console.WriteLine($"{hours + hoursNew}:0{minutesLeft}");
    }
    else if (minuteSum > 10 || minutesLeft > 10)
    {
        Console.WriteLine($"{hours + hoursNew}:{minutesLeft}");
    }

}

else
{
    Console.WriteLine($"{hours}:{minuteSum}");
}
