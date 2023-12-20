

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int maxPassCodes = int.Parse(Console.ReadLine());

int combinationCounter = 0;
bool moreThenMAxCodes = false;
bool cycleEnd = false;


for (int A = 35 ; A <= 55; A++)
{
   char symbolA = (char)A;

    for (int B = 64; B <= 96; B++)
    {

        char symbolB = (char)B;

        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= b; j++)
            {

                if (combinationCounter >= maxPassCodes)
                {
                    moreThenMAxCodes = true;
                    break;
                }
                Console.Write($"{symbolA}{symbolB}{i}{j}{symbolB}{symbolA}|");
                combinationCounter++;
                A++;
                symbolA = (char)A;
                B++;
                symbolB = (char)B;
                if (A > 55)
                {
                    A = 35;
                    symbolA = (char)A;
                }
                if (B > 96)
                {
                    B = 64;
                    symbolB = (char)B;
                }

                if (i==a && j == b)
                {
                    cycleEnd = true;
                    break;
                }
            }

            if (moreThenMAxCodes)
            {
                break;
            }
            if (cycleEnd)
            {
                break;
            }
        }
        if (moreThenMAxCodes)
        {
            break;
        }
        if (cycleEnd)
        {
            break;
        }
    }
    if (moreThenMAxCodes)
    {
        break;
    }
    if (cycleEnd)
    {
        break;
    }
}