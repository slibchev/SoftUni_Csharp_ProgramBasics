int men = int.Parse(Console.ReadLine());
int women = int.Parse(Console.ReadLine());
int freeTables = int.Parse(Console.ReadLine());

//int freeSeats = freeTables * 2;

for (int i = 1; i <= men; i++)
{
    if (freeTables <= 0)
    {
        break;
    }
    //freeSeats--;

    for (int j = 1; j <= women; j++)
    {
        if (freeTables <= 0)
        {
            break;
        }
        freeTables--;
        Console.Write($"({i} <-> {j}) ");
    }

}