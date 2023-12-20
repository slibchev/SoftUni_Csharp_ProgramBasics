double moneyForTrip = double.Parse(Console.ReadLine());
double jessieMoney = double.Parse(Console.ReadLine());

double moneyNeeded = 0;
int daysPassed = 0;
int badDays = 0;


while (moneyNeeded + jessieMoney < moneyForTrip)
{

    string type = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());


    if (type == "save")
    {
        daysPassed++;
        moneyNeeded += money;
        badDays = 0;
    }
    else if (type == "spend")
    {
        if (badDays > 5)
        {
            Console.WriteLine($"You can't save the money.");
            Console.WriteLine($"{badDays}");
            return;
        }
        daysPassed++;
        badDays++;
        moneyNeeded -= money;
        if (moneyNeeded < 0)
        {
            moneyNeeded = 0;
        }

    }

}
Console.WriteLine($"You saved the money for {daysPassed} days.");

