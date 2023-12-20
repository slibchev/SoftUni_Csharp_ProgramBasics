 double worldRecordTime = double.Parse(Console.ReadLine());
 double WorldRecordDistance = double.Parse(Console.ReadLine());    
double swimTimePerMeter = double.Parse(Console.ReadLine());


double waterResistance = Math.Floor(WorldRecordDistance / 15);

double timeNeeded = WorldRecordDistance * swimTimePerMeter + waterResistance * 12.5;


if (timeNeeded < worldRecordTime)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {timeNeeded:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecordTime - timeNeeded):f2} seconds slower.");
}





