double gameMoves = int.Parse(Console.ReadLine());


double totalPoints = 0;
int numberSet1 = 0;
int numberSet2 = 0;
int numberSet3 = 0;
int numberSet4 = 0;
int numberSet5 = 0;
int numberSet6 = 0;

for (int i = 0; i < gameMoves; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());

    if (currentNumber >= 0 && currentNumber <= 9)
    {
        totalPoints += 20 * currentNumber / 100;
        numberSet1++;
    }
    else if (currentNumber >= 10 &&  currentNumber <= 19)
    {
        totalPoints += 30 * currentNumber / 100;
        numberSet2++;
    }
    else if (currentNumber >= 20 && currentNumber <= 29)
    {
        totalPoints += 40 * currentNumber / 100;
        numberSet3++;
    }
    else if (currentNumber >= 30 && currentNumber <= 39)
    {
        totalPoints += 50;
        numberSet4++;
    }
    else if (currentNumber >= 40 && currentNumber <= 50)
    {
        totalPoints += 100;
        numberSet5++;
    }
    else if (currentNumber < 0 || currentNumber > 50)
    {
        totalPoints /= 2;
        numberSet6++;
    }

}

Console.WriteLine($"{totalPoints:f2}");
Console.WriteLine($"From 0 to 9: {numberSet1 / gameMoves * 100:f2}%");
Console.WriteLine($"From 10 to 19: {numberSet2 / gameMoves * 100:f2}%");
Console.WriteLine($"From 20 to 29: {numberSet3 / gameMoves * 100:f2}%");
Console.WriteLine($"From 30 to 39: {numberSet4 / gameMoves * 100:f2}%");
Console.WriteLine($"From 40 to 50: {numberSet5 / gameMoves * 100:f2}%");
Console.WriteLine($"Invalid numbers: {numberSet6 / gameMoves * 100:f2}%");
