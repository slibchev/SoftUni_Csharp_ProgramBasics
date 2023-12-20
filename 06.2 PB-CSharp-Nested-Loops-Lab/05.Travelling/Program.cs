string destination = Console.ReadLine();

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double moneySaved = 0;

    while (moneySaved < budget)
    {
        
        double money = double.Parse(Console.ReadLine());
        moneySaved += money;

        if (moneySaved >= budget)
        {
            Console.WriteLine($"Going to {destination}!");
        }
    }
    destination = Console.ReadLine();
}



