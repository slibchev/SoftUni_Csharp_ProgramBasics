double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = string.Empty;
string accomodation = string.Empty;

if (budget <= 100)
{
	destination = "Bulgaria";
	switch (season)
	{
		case "summer":

			budget = budget * 0.30;
			accomodation = "Camp";
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {budget:f2}");
            break;

		case "winter":

            budget = budget * 0.70;
            accomodation = "Hotel";
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {budget:f2}");
            break;
    }
}
else if (budget <= 1000)
{
	destination = "Balkans";
    switch (season)
    {
        case "summer":

            budget = budget * 0.40;
            accomodation = "Camp";
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {budget:f2}");
            break;

        case "winter":

            budget = budget * 0.80;
            accomodation = "Hotel";
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {budget:f2}");
            break;
    }

}
else if (budget > 1000)
{
    destination = "Europe";

     budget = budget * 0.90;
     accomodation = "Hotel";
    Console.WriteLine($"Somewhere in {destination}");
    Console.WriteLine($"{accomodation} - {budget:f2}");

}


