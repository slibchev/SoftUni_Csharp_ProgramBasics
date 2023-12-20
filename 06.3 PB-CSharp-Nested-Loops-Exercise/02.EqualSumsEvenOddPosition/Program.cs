int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());



for (int i = firstNum; i <= secondNum; i++)
{
   
    string curentNum = i.ToString();

    int even = 0;
    int odd = 0;

    for (int j = 0; j < curentNum.Length; j++)
    {
        char digit = curentNum[j];

        if (j % 2 == 0)
        {
            even += digit;
        }
        else
        {
            odd += digit;
        }

    }
    if (even == odd)
    {
        Console.Write($"{curentNum} ");
    }
}



