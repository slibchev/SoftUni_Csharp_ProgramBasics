int groups = int.Parse(Console.ReadLine());

double Musalagroup = 0;
double MonBlangroup = 0;
double Kilimanjarogroup = 0;
double K2group = 0;
double Everestgroup = 0;
double totalPeople = 0;

for (int i = 0; i < groups; i++)
{
    double groupMembers = double.Parse(Console.ReadLine());

	if (groupMembers <= 5)
    {
        Musalagroup += groupMembers;
        totalPeople += groupMembers;
    }
    else if (groupMembers >= 6 && groupMembers <= 12)
    {
        MonBlangroup += groupMembers;
        totalPeople += groupMembers;
    }
    else if (groupMembers >= 13 && groupMembers <= 25)
    {
        Kilimanjarogroup += groupMembers;
        totalPeople += groupMembers;
    }
    else if (groupMembers >= 26 && groupMembers <= 40)
    {
        K2group += groupMembers;
        totalPeople += groupMembers;
    }
    else if (groupMembers > 40)
    {
        Everestgroup += groupMembers;
        totalPeople += groupMembers;
    }

}
Console.WriteLine($"{Musalagroup / totalPeople * 100:f2}%");
Console.WriteLine($"{MonBlangroup / totalPeople * 100:f2}%");
Console.WriteLine($"{Kilimanjarogroup / totalPeople * 100:f2}%");
Console.WriteLine($"{K2group / totalPeople * 100:f2}%");
Console.WriteLine($"{Everestgroup / totalPeople * 100:f2}%");
 