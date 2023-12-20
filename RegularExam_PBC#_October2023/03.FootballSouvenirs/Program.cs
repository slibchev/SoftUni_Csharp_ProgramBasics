
string team = Console.ReadLine();
string suvenier = Console.ReadLine();
int suvenierCount =int.Parse(Console.ReadLine());

double itemSum = 0;
string itemtype = string.Empty;
bool correctCountry = false;
bool correctItem = false;



if ( team == "Argentina")
{
    correctCountry = true;
	switch (suvenier)
	{
		case "flags":
            correctItem = true;
                itemSum += suvenierCount *3.25;
            itemtype = "flags";
            break;
        case "caps":
            correctItem = true;
            itemSum += suvenierCount * 7.20;
            itemtype = "caps";
            break;
        case "posters":
            correctItem = true;
            itemSum += suvenierCount * 5.10;
            itemtype = "poster";
            break;
        case "stickers":
            correctItem = true;
            itemSum += suvenierCount * 1.25;
            itemtype = "stickers";
            break;
    }
}
else if (team == "Brazil")
{
    correctCountry = true;
    switch (suvenier)
    {
        case "flags":
            correctItem = true;
            itemSum += suvenierCount * 4.20;
            itemtype = "flags";
            break;
        case "caps":
            correctItem = true;
            itemSum += suvenierCount * 8.50;
            itemtype = "caps";
            break;
        case "posters":
            correctItem = true;
            itemSum += suvenierCount * 5.35;
            itemtype = "poster";
            break;
        case "stickers":
            correctItem = true;
            itemSum += suvenierCount * 1.20;
            itemtype = "stickers";
            break;
    }
}
else if (team == "Croatia")
{
    correctCountry = true;
    switch (suvenier)
    {
        case "flags":
            correctItem = true;
            itemSum += suvenierCount * 2.75;
            itemtype = "flags";
            break;
        case "caps":
            correctItem = true;
            itemSum += suvenierCount * 6.90;
            itemtype = "caps";
            break;
        case "posters":
            correctItem = true;
            itemSum += suvenierCount * 4.95;
            itemtype = "poster";
            break;
        case "stickers":
            correctItem = true;
            itemSum += suvenierCount * 1.10;
            itemtype = "stickers";
            break;
    }
}
else if (team == "Denmark")
{
    correctCountry = true;
    switch (suvenier)
    {
        case "flags":
            correctItem = true;
            itemSum += suvenierCount * 3.10;
            itemtype = "flags";
            break;
        case "caps":
            correctItem = true;
            itemSum += suvenierCount * 6.50;
            itemtype = "caps";
            break;
        case "posters":
            correctItem = true;
            itemSum += suvenierCount * 4.80;
            itemtype = "poster";
            break;
        case "stickers":
            correctItem = true;
            itemSum += suvenierCount * 0.90;
            itemtype = "stickers";
            break;
    }
}


if (correctCountry && correctItem)
{
    Console.WriteLine($"Pepi bought { suvenierCount} {itemtype} of {team} for {itemSum:F2} lv.");
}
else if (correctCountry && !correctItem)
{
    Console.WriteLine("Invalid stock!");
}
else if (!correctCountry && !correctItem)
{
    Console.WriteLine("Invalid country!");
}


