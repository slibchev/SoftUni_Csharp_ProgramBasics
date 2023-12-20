
int n = int.Parse(Console.ReadLine());
int validCombination = 0;

for (int x = 0; x <= n; x++)
{
    for (int y = 0; y <=n; y++)
    {
        for (int z = 0; z <= n; z++)
        {
            if (x + y + z == n)
            {
                validCombination++;
            }
            
        }
    }
}

Console.WriteLine(validCombination);
