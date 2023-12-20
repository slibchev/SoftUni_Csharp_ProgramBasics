int lilyAge = int.Parse(Console.ReadLine());
double washingMaschine = double.Parse(Console.ReadLine());
int toyPrice  = int.Parse(Console.ReadLine());

double savedMoney = 0;
int moneyIncrease = 10;
int toyCount = 0;

for (int i = 1; i <=lilyAge; i++)
{
    if (i % 2 == 0)
    {
         
         savedMoney += moneyIncrease;
         moneyIncrease += 10;
         savedMoney -= 1;
    }
    else
     {
        toyCount++;
    }
}

double moneyFromToys = toyCount * toyPrice;
double moneyToSpend = savedMoney + moneyFromToys;

if (moneyToSpend >= washingMaschine)
{
    Console.WriteLine($"Yes! {moneyToSpend - washingMaschine:f2}");
}
else
{
    Console.WriteLine($"No! {washingMaschine - moneyToSpend:f2}");
}