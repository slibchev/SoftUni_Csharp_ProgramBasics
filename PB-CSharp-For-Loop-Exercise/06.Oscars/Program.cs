string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int juryMembers = int.Parse(Console.ReadLine());


double juryPoints = 0;
double OskarPoints = 1250.5;

for (int i = 1; i <= juryMembers; i++)
{
    int juryNameLenth = 0;

    string juryMemberName = Console.ReadLine();
    double juryMemberPoint = double.Parse(Console.ReadLine());
    

    juryNameLenth = juryMemberName.Length;
    double currentMemeberPoints = juryNameLenth * juryMemberPoint / 2;
    juryPoints += currentMemeberPoints;
    currentMemeberPoints -= currentMemeberPoints;


    if (academyPoints + juryPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with" +
            $" {academyPoints + juryPoints:f1}!");
        break;
    }
}

if (academyPoints + juryPoints < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {OskarPoints - (academyPoints + juryPoints):f1} more!");
}
