double fishTankLenth = int.Parse(Console.ReadLine());
int fishTankWidth = int.Parse(Console.ReadLine());
int fishTankHight = int.Parse(Console.ReadLine());
double accessoriesPercent = double.Parse(Console.ReadLine());


double tankVolume =  fishTankLenth * fishTankWidth * fishTankHight/1000;
double waterVolume = tankVolume - (tankVolume * accessoriesPercent/100);

Console.WriteLine(waterVolume);