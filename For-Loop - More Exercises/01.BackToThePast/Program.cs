double money = double.Parse(Console.ReadLine());    
int year = int.Parse(Console.ReadLine());


int IvanchoAge = 18;

for (int i = 1800; i <= year; i++)
{
    
    double EvenYearCost = 12000;
    double OddYearCost = 12000 + (50 * IvanchoAge);

    if ( i % 2 == 0)
    {
        money -= EvenYearCost;
    }
    else
    {
        money -= OddYearCost;
    }

    IvanchoAge++;
}


if(money >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
}
