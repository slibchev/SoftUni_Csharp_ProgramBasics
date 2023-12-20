int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int combiantionCounter = 0;
bool isFound = false;
int sum = 0;

for (int i = startNum; i <= endNum; i++)
{
	for (int j = startNum; j <= endNum ; j++)
	{
		sum = i + j;
        combiantionCounter++;

        if (sum == magicNum )
		{
            Console.WriteLine($"Combination N:{combiantionCounter} ({i} + {j} = {sum})");
            isFound = true;
			break;
        }
		sum = 0;
	}

	if (isFound)
	{
		break;
	}
    
}
if(sum != magicNum)
Console.WriteLine($"{combiantionCounter} combinations - neither equals {magicNum}");
