int tabsOpened = int.Parse(Console.ReadLine());
double salary = int.Parse(Console.ReadLine());


int penaltySum = 0;

for (int i = 1; i <= tabsOpened; i++)
{
    string webPage = Console.ReadLine();

	switch (webPage)
	{
		case "Facebook":
			penaltySum += 150;
			break;
		case "Instagram":
			penaltySum += 100;
			break;
		case "Reddit":
			penaltySum += 50;
			break;
	}
	if (salary <= penaltySum)
	{
        Console.WriteLine("You have lost your salary.");
        break;

	}
    
}
if (salary > penaltySum)
{
    Console.WriteLine(salary - penaltySum);
}



