string town = Console.ReadLine();
double productQuantity = double.Parse(Console.ReadLine());

bool correctCity = town =="Sofia" || town =="Varna" || town == "Plovdiv";

if (!correctCity || productQuantity < 0)
{
    Console.WriteLine("error");
}


if (productQuantity >= 0 && productQuantity  <= 500)
{
	switch (town)
	{
        case "Sofia":
            Console.WriteLine($"{productQuantity * 0.05:f2}");
        break;

        case "Varna":
            Console.WriteLine($"{productQuantity * 0.045:f2}");
            break;
        case "Plovdiv":
            Console.WriteLine($"{productQuantity * 0.055:f2}");
            break;
	}
}
else if (productQuantity > 500 && productQuantity <= 1000)
{
    switch (town)
    {
        case "Sofia":
            Console.WriteLine($"{productQuantity * 0.07:f2}");
            break;

        case "Varna":
            Console.WriteLine($"{productQuantity * 0.075:f2}");
            break;
        case "Plovdiv":
            Console.WriteLine($"{productQuantity * 0.08:f2}");
            break;
    }
}
else if (productQuantity > 1000 && productQuantity <= 10000)
{
    switch (town)
    {
        case "Sofia":
            Console.WriteLine($"{productQuantity * 0.08:f2}");
            break;

        case "Varna":
            Console.WriteLine($"{productQuantity * 0.1:f2}");
            break;
        case "Plovdiv":
            Console.WriteLine($"{productQuantity * 0.12:f2}");
            break;
    }
}
else if (productQuantity >10000)
{
    switch (town)
    {
        case "Sofia":
            Console.WriteLine($"{productQuantity * 0.12:f2}");
            break;

        case "Varna":
            Console.WriteLine($"{productQuantity * 0.13:f2}");
            break;
        case "Plovdiv":
            Console.WriteLine($"{productQuantity * 0.145:f2}");
            break;
    }
}
