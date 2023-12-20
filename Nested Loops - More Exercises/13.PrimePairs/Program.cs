int firstPairStart = int.Parse(Console.ReadLine());
int secondPairStart = int.Parse(Console.ReadLine());
int firstPairEnd = int.Parse(Console.ReadLine());
int secondPairEnd = int.Parse(Console.ReadLine());



for (int i = firstPairStart; i <= firstPairStart + firstPairEnd; i++)
{
    bool firstPairIsCorrect = true;

    for ( int k = 2 ; k < i; k++)
    {
       
        if (i % k == 0)
        {
            firstPairIsCorrect  = false;
            break;
        }
        
    }


    for (int j = secondPairStart; j <= secondPairStart + secondPairEnd; j++)
    {

        bool secondPairIsCorrect = true;

        for (int f = 2; f < j; f++)
        {
           
            if (j % f == 0)
            {
                secondPairIsCorrect = false;
                break;
            }

        }

        if (firstPairIsCorrect && secondPairIsCorrect)
        {
            Console.WriteLine($"{i}{j}");
        }

    }


}