double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();

switch (gender)
{
	case "m":
        if (age < 16)
        {
            Console.WriteLine("Master");
        }
        else if (age >= 16)
        {
            Console.WriteLine("Mr.");
        }      
		break;
    case "f":
        if (age < 16)
        {
            Console.WriteLine("Miss");
        }
        else if(age >= 16)
        {
            Console.WriteLine("Ms.");
        }
        break;
}
