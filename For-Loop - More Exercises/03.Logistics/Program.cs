int cargo = int.Parse(Console.ReadLine());

double cargoTotalPrice = 0;
double microbusCargo = 0;
double truckCargo = 0;
double trainCargo = 0;
double totalCargo = 0;

for (int i = 0; i < cargo; i++)
{
    double cargoWeight = int.Parse(Console.ReadLine());

    if (cargoWeight >= 1 && cargoWeight <= 3)
    {
        cargoTotalPrice += cargoWeight * 200;
        microbusCargo += cargoWeight;
        totalCargo += cargoWeight;
    }
    else if (cargoWeight >= 4 && cargoWeight <= 11)
    {
        cargoTotalPrice += cargoWeight * 175;
        truckCargo += cargoWeight;
        totalCargo += cargoWeight;
    }
    else
    {
        cargoTotalPrice += cargoWeight * 120;
        trainCargo += cargoWeight;
        totalCargo += cargoWeight;
    }



}

double averagePricePerTon = cargoTotalPrice / totalCargo;

Console.WriteLine($"{averagePricePerTon:f2}");
Console.WriteLine($"{microbusCargo / totalCargo * 100:f2}%");
Console.WriteLine($"{truckCargo / totalCargo * 100:f2}%");
Console.WriteLine($"{trainCargo / totalCargo * 100:f2}%");