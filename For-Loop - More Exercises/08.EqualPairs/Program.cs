int cycles = int.Parse(Console.ReadLine());


int pairValue = 0;
bool allMatch = false;
int maxDifference = int.MinValue;
int pairMatch = 1;

for (int i = 0; i < cycles; i++)
{


    int currentNum1 = int.Parse(Console.ReadLine());
    int currentNum2 = int.Parse(Console.ReadLine());

    int currentPairValue = currentNum1 + currentNum2;

    if (currentPairValue == pairValue)
    {
        pairMatch++;
        if (pairMatch == cycles)
        {
            allMatch = true;
            break;
        }
    }
    int currentMaxDiff = int.MinValue;

    


    pairValue = currentPairValue;

}
if (allMatch)
{
    Console.WriteLine($"Yes, value={pairValue}");
}
else
{
    Console.WriteLine($"No, maxdiff={maxDifference}");
}
