int input = int.Parse(Console.ReadLine());

double evenNumSum = 0;
double evenNumMax = double.MinValue;
double evenNumMin = double.MaxValue;

double oddNumSum = 0;
double oddNumMax = double.MinValue;
double oddNumMin = double.MaxValue;


for (int i = 1; i < input; i++)
{
    double currentNums = double.Parse(Console.ReadLine());

    if (i % 2 != 0)
    {
        oddNumSum += currentNums;
        if (currentNums > oddNumMax)
        {
            oddNumMax = currentNums;
        }

        if (currentNums < oddNumMax)
        {
            oddNumMin = currentNums;
        }
    }
    else
    {
        evenNumSum += currentNums;
        if (currentNums > evenNumMax)
        {
            evenNumMax = currentNums;
        }

        if (currentNums < evenNumMax)
        {
            evenNumMin = currentNums;
        }
    }



}

Console.WriteLine($"OddSum= + {oddNumSum:f2}");
