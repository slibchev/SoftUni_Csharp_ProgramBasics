int restingDays = int.Parse(Console.ReadLine());

double playtimeinHours = 30000 / 60;
double playtimeinMinutes = 30000 % 60;
int workingDays = 365 - restingDays;
double PlayLimit = 30000;


double restingPlayTime = restingDays * 127;
double workingPlaytime = workingDays * 63;
double TomTotalplaytime = restingDays + workingDays;

if (TomTotalplaytime > PlayLimit)
{
    Console.WriteLine($"Tom will run away");
    Console.WriteLine($"{playtimeinHours} hours and {playtimeinMinutes} more for play.");
}
else
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{H} hours and {M} minutes less for play");
}
