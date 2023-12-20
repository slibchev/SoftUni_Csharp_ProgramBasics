
string input = Console.ReadLine();

int primeNum = 0;
int nonPrimeNum = 0;


while (input != "stop")
{
    int currentNum = int.Parse(input);

    if (currentNum < 0)
    {
        Console.WriteLine("Number is negative.");
        input = Console.ReadLine();
        continue;
    }
   
    bool isPrime = true;

    for (int i = 2; i < currentNum; i++)
    {
        if (currentNum % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        primeNum += currentNum;
    }
    else
    {
        nonPrimeNum += currentNum;
    }


    input = Console.ReadLine();
}

Console.WriteLine($"Sum of all prime numbers is: {primeNum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNum}");


