
double smallGroup = 0;
double middGroup = 0;
double bigGroup = 0;
double priceForFood = 12.45/1000;
double foodSumPrice = 0;

int catsNumber = int.Parse(Console.ReadLine());
 
for (int i = 1; i <= catsNumber; i++)
{
    double currentFood = double.Parse(Console.ReadLine());

    if (currentFood >= 100 && currentFood <200)
    {
        smallGroup++;
        foodSumPrice += currentFood * priceForFood;
    }
    else if (currentFood >= 200 && currentFood <300)
    {
        middGroup++;
        foodSumPrice += currentFood * priceForFood;


    }
    else if (currentFood >=300 && currentFood < 400)
    {
        bigGroup++;
        foodSumPrice += currentFood * priceForFood;
    }


}

Console.WriteLine($"Group 1: {smallGroup} cats.");
Console.WriteLine($"Group 2: {middGroup} cats.");
Console.WriteLine($"Group 3: {bigGroup} cats.");
Console.WriteLine($"Price for food per day: {foodSumPrice:f2} lv.");