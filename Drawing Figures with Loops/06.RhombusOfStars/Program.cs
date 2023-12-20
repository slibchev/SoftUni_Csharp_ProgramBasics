
int n = int.Parse(Console.ReadLine());

int columCount = 1;

for (int row = 0; row < n - 1; row++)
{
    Console.Write(new string(' ', n - columCount));

    for (int col = 0; col < columCount; col++)
    {

        Console.Write("* ");
    }
    Console.WriteLine();
    columCount++;
}
for (int col = 0; col < n; col++)
{
    Console.Write("* ");
}
Console.WriteLine();

columCount = n - 1;

for (int row = 0; row < n - 1; row++)
{
    Console.Write(new string(' ', n - columCount));

    for (int col = 0; col < columCount; col++)
    {

        Console.Write("* ");
    }
    Console.WriteLine();
    columCount--;
}
