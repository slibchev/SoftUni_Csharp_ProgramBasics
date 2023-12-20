

int numberOfLocations = int.Parse(Console.ReadLine());



for (int i = 1; i <= numberOfLocations; i++)
{

    double locationGold = 0;

    double dailyExpectedGold = double.Parse(Console.ReadLine());
    int workingDays = int.Parse(Console.ReadLine());

    for (int j = 1; j <= workingDays; j++)
    {

        double currentGold = double.Parse(Console.ReadLine());
        locationGold += currentGold;

    }

    double averageGoldPerDay = locationGold / workingDays;

    if (averageGoldPerDay >= dailyExpectedGold)
    {
        Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:f2}.");
    }
    else
    {
        Console.WriteLine($"You need {dailyExpectedGold - averageGoldPerDay:f2} gold.");
    }
}