string serialName = Console.ReadLine();
int episodeLenth = int.Parse(Console.ReadLine());
int lunchBreak = int.Parse(Console.ReadLine());

double timeToEat = lunchBreak * 0.125;
double restingTIme = lunchBreak * 0.25;
double timeToEatAndRest = timeToEat + restingTIme;
double timeToWatch = lunchBreak - timeToEatAndRest;

if(timeToWatch >= episodeLenth)
{
    Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeToWatch - episodeLenth)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeLenth - timeToWatch)} more minutes.");
}

