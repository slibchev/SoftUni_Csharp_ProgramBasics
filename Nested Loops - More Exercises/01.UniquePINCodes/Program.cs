int firstDigit = int.Parse(Console.ReadLine());
int secondDigit = int.Parse(Console.ReadLine());
int thirdDigit = int.Parse(Console.ReadLine());

bool isSimple = false;

for (int i = 2; i <= firstDigit; i++)
{


    for (int j = 1; j <=secondDigit; j++)
    {

        if ( j == 2 || j == 3 || j == 5 || j == 7)
        {
            isSimple = true;
        }
        else
        {
            isSimple = false;
        }

        for (int k = 2; k <= thirdDigit; k++)
        {

            if ( i % 2 == 0 && isSimple && k % 2 == 0 )
            {
                Console.WriteLine($"{i} {j} {k}");
            }


        }
    }
}