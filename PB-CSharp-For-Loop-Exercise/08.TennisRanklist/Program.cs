int tournierCount = int.Parse(Console.ReadLine());
double initialPoint = double.Parse(Console.ReadLine());

double pointGain = 0;
int tournierWon = 0;


for (int i = 0; i < tournierCount; i++)
{
    string position = Console.ReadLine();

	switch (position)
	{
		case "W":
			pointGain += 2000;
			tournierWon ++;
			break;
		case "F":
            pointGain += 1200;
            break;
		case "SF":
            pointGain += 720;
            break;
	}
}

double averagePoints = pointGain / tournierCount;
double finalPoints = initialPoint + pointGain;
double percentWon = (double)tournierWon / tournierCount * 100;

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{percentWon:f2}%");
