int n = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());



for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        int cycleCounter1 = 0;

        for (char k = 'a'; k <= 'z'; k++)
        {
            cycleCounter1++;

            if (cycleCounter1 > l)
            {
                break;
            }

            int cycleCounter2 = 0;

            for (char y = 'a'; y <= 'z'; y++)
            {
                cycleCounter2++;

                if (cycleCounter2 > l)
                {
                    break;
                }

                for (int d = 1; d <=n; d++)
                {

                    if (d > i && d > j)
                    {
                        Console.Write($"{i}{j}{k}{y}{d} ");
                    }


                }


            }

        }
    }
}