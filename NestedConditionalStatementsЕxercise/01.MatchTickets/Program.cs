int budget = int.Parse(Console.ReadLine());
string ticketCategory = Console.ReadLine();
int peopleCount = int.Parse(Console.ReadLine());

double transportCost = 0;
double moneyForTuckets = budget - transportCost;
double finalBudget = 0;
double ticketPrice = 0;



if (peopleCount >= 1 && peopleCount  <= 4)
{
    transportCost = budget * 0.75;

    if (ticketCategory == "Normal")
    {
        ticketPrice = 249.99 * peopleCount;
    }
    else
    {
        ticketPrice = 499.99 * peopleCount;
    }
}
else if (peopleCount >4 &&  peopleCount <= 9)
{
    transportCost = budget * 0.6;

    if (ticketCategory == "Normal")
    {
        ticketPrice = 249.99 * peopleCount;
    }
    else
    {
        ticketPrice = 499.99 * peopleCount;
    }

}
else if (peopleCount > 9 && peopleCount <= 24)
{
    transportCost = budget * 0.5;

    if (ticketCategory == "Normal")
    {
        ticketPrice = 249.99 * peopleCount;
    }
    else
    {
        ticketPrice = 499.99 * peopleCount;
    }
}
else if (peopleCount > 24 && peopleCount <= 49)
{
    transportCost = budget * 0.4;
    if (ticketCategory == "Normal")
    {
        ticketPrice = 249.99 * peopleCount;
    }
    else
    {
        ticketPrice = 499.99 * peopleCount;
    }
}
else
{
    transportCost = budget * 0.25;

    if (ticketCategory == "Normal")
    {
        ticketPrice = 249.99 * peopleCount;
    }
    else
    {
        ticketPrice = 499.99 * peopleCount;
    }
}

moneyForTuckets = budget - transportCost;

if (budget > transportCost)
{
    Console.WriteLine($"Yes! You have {moneyForTuckets - ticketPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {ticketPrice - moneyForTuckets:f2} leva.");
}
