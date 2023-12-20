int oneLevCoinsCount = int.Parse(Console.ReadLine());
int twoLevCoinsCount = int.Parse(Console.ReadLine());
int fiveLevaBanknoteCount = int.Parse(Console.ReadLine());
int sum = int.Parse(Console.ReadLine());


for (int i = 0; i <= oneLevCoinsCount; i++)
{
    int oneLev = i * 1;


    for (int j = 0; j <= twoLevCoinsCount; j++)
    {
        int twoLev = j * 2;


        for (int k = 0; k <= fiveLevaBanknoteCount; k++)
        {
            int fiveLeva = k * 5;

            if (oneLev + twoLev + fiveLeva  == sum)
            {
                Console.WriteLine($"{i} * {1} lv. + {j} * {2} lv. + {k} * {5} lv. = {sum} lv.");

            }
        }
    }
}