string month = Console.ReadLine();
int nightsCount = int.Parse(Console.ReadLine());

double studioPrice = 0;
double aparmentPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50;
    aparmentPrice = 65;

    if (nightsCount > 7 && nightsCount <= 14)
    {
        studioPrice = studioPrice * 0.95;
    }
    else if (nightsCount > 14)
    {
        studioPrice = studioPrice * 0.7;
        aparmentPrice = aparmentPrice * 0.9;
    }
}
else if (month == "June" || month == "September ")
{
    studioPrice = 75.20;
    aparmentPrice = 68.70;

    if(nightsCount > 14)
    {
        studioPrice = studioPrice * 0.8;
        aparmentPrice = aparmentPrice * 0.9;
    }
}
else if (month == "July" || month == "August")
{
    studioPrice = 76;
    aparmentPrice = 77;

    if (nightsCount > 14)
    {
        aparmentPrice = aparmentPrice *0.9;
    }
}

Console.WriteLine($"Apartment: {nightsCount * aparmentPrice:f2} lv.");
Console.WriteLine($"Studio: {nightsCount * studioPrice:f2} lv.");



