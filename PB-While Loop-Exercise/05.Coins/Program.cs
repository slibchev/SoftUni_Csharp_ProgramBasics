double change = double.Parse(Console.ReadLine())*100;


int changeBack = 0;
int coinsCounter = 0;


while (change > 0)
{
    if (change - 200 >= 0)
    {
        changeBack += 200;
        coinsCounter++;
    }
    else if (change - 100 >= 0)
    {
        changeBack += 100;
        coinsCounter++;
    }
    else if (change - 50 >= 0)
    {
        changeBack += 50;
        coinsCounter++;
    }
    else if (change - 20 >= 0)
    {
        changeBack += 20;
        coinsCounter++;
    }
    else if (change - 10 >= 0)
    {
        changeBack += 10;
        coinsCounter++;
    }
    else if (change - 5 >= 0)
    {
        changeBack += 5;
        coinsCounter++;
    }
    else if (change - 2 >= 0)
    {
        changeBack += 2;
        coinsCounter++;
    }
    else if (change - 1 >= 0)
    {
        changeBack += 1;
        coinsCounter++;
    }

     change -= changeBack;
     changeBack = 0;

}

Console.WriteLine($"{coinsCounter}");
