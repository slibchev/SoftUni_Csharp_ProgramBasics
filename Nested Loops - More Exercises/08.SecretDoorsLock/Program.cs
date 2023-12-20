int firstNum = int.Parse(Console.ReadLine());
int secondtNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());

bool isSimple = false;


for (int i = 1; i <= firstNum; i++)
{
    for (int j = 2; j <= secondtNum; j++)
    {
        isSimple = false;

        if (j == 2 || j == 3 || j == 5 || j == 7 )
        {
            isSimple = true;
        }
        for (int k = 1; k <= thirdNum; k++)
        {

            if (i % 2 == 0 && k % 2 == 0 && isSimple)
            {
                Console.WriteLine($"{i} {j} {k}");
            }

        }
    }
}