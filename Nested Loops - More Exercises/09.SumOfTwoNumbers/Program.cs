int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int combinationCounter = 0;
bool isNotFound = true;

for (int i = startNum; i <= endNum; i++)
{
    for (int j = startNum ; j <= endNum; j++)
    {
        combinationCounter++;

        if (i + j == magicNum)
        {
            Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNum})");
            isNotFound = false;
            break;
        }
    }
    if (!isNotFound)
    {
        break;
    }
}
if (isNotFound)
{
    Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");
}


