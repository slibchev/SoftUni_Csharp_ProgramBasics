int budget = int.Parse(Console.ReadLine());
string season  = Console.ReadLine();
int fisherMen = int.Parse(Console.ReadLine());

double shipPrice = 0;


if (season == "Spring")
{
    shipPrice = 3000;
    switch (fisherMen)
    {
        case <= 6:
            shipPrice = shipPrice - shipPrice * 0.1;
            break;
        case <= 11:
            shipPrice = shipPrice - shipPrice * 0.15; 
            break;
        case > 12:
            shipPrice = shipPrice - shipPrice * 0.25;
            break;
    }

}
else if (season == "Summer")
{
    shipPrice = 4200;
    switch (fisherMen)
    {
        case <= 6:
            shipPrice = shipPrice - shipPrice * 0.1;
            break;
        case <= 11:
            shipPrice = shipPrice - shipPrice * 0.15;
            break;
        case > 12:
            shipPrice = shipPrice - shipPrice * 0.25;
            break;

}  }
else if (season == "Autumn")
{
    shipPrice = 4200;
    shipPrice = 4200;
    switch (fisherMen)
    {
        case <= 6:
            shipPrice = shipPrice - shipPrice * 0.1;
            break;
        case <= 11:
            shipPrice = shipPrice  - shipPrice * 0.15;
            break;
        case > 12:
            shipPrice = shipPrice - shipPrice * 0.25;
            break;
}   }
else if(season == "Winter")
{
    shipPrice = 2600;

    switch (fisherMen)
    {
        case <= 6:
            shipPrice = shipPrice - shipPrice * 0.1;
            break;
        case <= 11:
            shipPrice = shipPrice - shipPrice * 0.15;
            break;
        case > 12:
            shipPrice = shipPrice - shipPrice * 0.25;
            break;
}   }


if (fisherMen % 2 == 0 && season != "Autumn")
{
    shipPrice =  shipPrice - shipPrice * 0.05;
}




if (budget >= shipPrice)
{
    Console.WriteLine($"Yes! You have {budget - shipPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {shipPrice - budget:f2} leva.");
}