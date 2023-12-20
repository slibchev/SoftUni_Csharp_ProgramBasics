


int youngPeople = 0;
int maturePeople = 0;
double toysPriceSum  = 0;
double puloverPriceSum = 0;

string input = Console.ReadLine();


while (input!= "Christmas")
{


    int currentAge = int.Parse(input);

    if (currentAge <= 16)
    {
        youngPeople++;
        toysPriceSum += 5;
    }
    else
    {
        maturePeople++;
        puloverPriceSum += 15;
    }

    input = Console.ReadLine();
    


}

Console.WriteLine($"Number of adults: {maturePeople}");
Console.WriteLine($"Number of kids: {youngPeople}");
Console.WriteLine($"Money for toys: {toysPriceSum}");
Console.WriteLine($"Money for sweaters: {puloverPriceSum}");