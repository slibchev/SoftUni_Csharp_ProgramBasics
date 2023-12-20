int days = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double totalSum = 0;

for (int i = 1; i <= days; i++)
{
    double dailySum = 0;

   for (int j = 1; j <= hours; j++)
   {

        if (i % 2 == 0 && j % 2 !=0)
        {

            dailySum += 2.50;

        }
        else if (i % 2 == 0 && j % 2 ==0)
        {

            dailySum += 1.00;

        }
        else if (i % 2 != 0 &&  j % 2 == 0)
        {
            dailySum += 1.25;
        }
        else
        {
            dailySum += 1.00;
        }


   }

    Console.WriteLine($"Day: {i} - {dailySum:F2} leva");
    totalSum += dailySum;

}

Console.WriteLine($"Total: {totalSum:F2} leva");