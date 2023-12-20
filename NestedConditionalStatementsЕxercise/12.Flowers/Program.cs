int hrizantemaCount = int.Parse(Console.ReadLine());
int rosesCount = int.Parse(Console.ReadLine());
int tulipsCount = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string dayType = Console.ReadLine();

double hrizantemaPrice = 0;
double rosesPrice = 0;
double tulipPrice = 0;

if (season == "Spring" || season == "Summer")
{

    if (dayType == "N")
    {
        hrizantemaPrice = hrizantemaCount * 2;
        rosesPrice = rosesCount * 4.10;
        tulipPrice = tulipsCount * 2.50;
    }
    else if (dayType == "Y")
    {
       
    }

}
else if (season == "Autumn" || season == "Winter")
{
    if (dayType == "N")
    {
        hrizantemaPrice = hrizantemaCount * 3.75;
        rosesPrice = rosesCount * 4.50;
        tulipPrice = tulipsCount * 4.15;

    }
    else if (dayType == "Y")
    {
        hrizantemaPrice = hrizantemaCount * 2;
        rosesPrice = rosesCount * 4.10;
        tulipPrice = tulipsCount * 2.50;

    }
}


