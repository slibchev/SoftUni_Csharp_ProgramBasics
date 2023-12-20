double stadiumCapacity = int.Parse(Console.ReadLine());    
int fenCount = int.Parse(Console.ReadLine());

double fenSectorA = 0;
double fenSectorB = 0;
double fenSectorV = 0;
double fenSectorG = 0;


for (int i = 0; i < fenCount; i++)
{
    string currentSector = Console.ReadLine();

    if (currentSector == "A")
    {
        fenSectorA++;
    }
    else if (currentSector == "B")
    {
        fenSectorB++;
    }
    else if (currentSector == "V")
    {
        fenSectorV++;
    }
    else if (currentSector == "G")
    {
        fenSectorG++;
    }



}

Console.WriteLine($"{fenSectorA / fenCount * 100:f2}%");
Console.WriteLine($"{fenSectorB / fenCount * 100:f2}%");
Console.WriteLine($"{fenSectorV / fenCount * 100:f2}%");
Console.WriteLine($"{fenSectorG / fenCount * 100:f2}%");
Console.WriteLine($"{fenCount/stadiumCapacity*100:f2}%");
