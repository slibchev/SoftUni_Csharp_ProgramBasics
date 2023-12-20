string input = Console.ReadLine();

double total = 0;


while (input != "NoMoreMoney")
{
    double currentMoney = double.Parse(input);

    if (currentMoney < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    
    Console.WriteLine($"Increase: {currentMoney:F2}");
    total += currentMoney;





    input = Console.ReadLine();
}
Console.WriteLine($"Total: {total:f2}");
