int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());


for (int i = startNum; i <= endNum; i++)
{


	for (int j = startNum; j <= endNum; j++)
	{


		for (int k = startNum; k <= endNum; k++)
		{


			for (int l = startNum; l <= endNum; l++)
			{
				if (i % 2 == 0 && i > l && (j+k) % 2 == 0 && l % 2 != 0)
				{
                    Console.Write($"{i}{j}{k}{l} ");
                }
				else if (i % 2 != 0 && i > l && (j + k) % 2 == 0 && l % 2 == 0)
				{
                    Console.Write($"{i}{j}{k}{l} ");
                }




            }
		}
	}
}