

int processorsToMake = int.Parse(Console.ReadLine());
int workersCount  = int.Parse(Console.ReadLine());
int workingDays  = int.Parse(Console.ReadLine());

//double processorPrice = 110.10;
double workingTime =  workingDays * 8 * workersCount;
double processorsDone = Math.Floor(workingTime /3);


double profit = processorsDone * 110.10 - processorsToMake * 110.10;
//double netProfit = profit - processorsToMake * 110.10;

if (processorsDone >= processorsToMake)
{
    Console.WriteLine($"Profit: -> {Math.Abs(profit):f2} BGN");
}
else
{
    Console.WriteLine($"Losses: -> {Math.Abs(profit):f2} BGN");
}