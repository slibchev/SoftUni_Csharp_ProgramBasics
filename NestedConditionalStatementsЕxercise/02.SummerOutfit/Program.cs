int deGreece = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

string outfit = string.Empty;
string shoes = string.Empty;

switch (dayTime)
{
	case "Morning":
		if (deGreece >= 10 && deGreece <= 18)
		{
			outfit = "Sweatshirt";
			shoes = "Sneakers";
        }
		else if (deGreece >18 && deGreece <= 24)
		{
            outfit = "Shirt";
            shoes = "Moccasins";
        }
		else
		{
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
		break;

	case "Afternoon":
        if (deGreece >= 10 && deGreece <= 18)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (deGreece > 18 && deGreece <= 24)
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else
        {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        }
        break;

    case "Evening":
        outfit = "Shirt";
        shoes = "Moccasins";
        break;




}

Console.WriteLine($"It's {deGreece} degrees, get your {outfit} and {shoes}.");
