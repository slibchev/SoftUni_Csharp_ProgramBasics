int inputCount = int.Parse(Console.ReadLine());

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;


for (int i = 0; i < inputCount; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum < 200)
    {
        p1++;
    }
    else if (currentNum >= 200 &&  currentNum <= 399)
    {
        p2++;
    }
    else if (currentNum >= 400 && currentNum <= 599)
    {
        p3++;
    }
    else if (currentNum >= 600 && currentNum <= 799)
    {
        p4++;
    }
    else
    {
        p5++;
    }

}


Console.WriteLine($"{1.0 * p1 / inputCount * 100:f2}%");
Console.WriteLine($"{1.0 * p2 / inputCount * 100:f2}%");
Console.WriteLine($"{1.0 * p3 / inputCount * 100:f2}%");
Console.WriteLine($"{1.0 * p4 / inputCount * 100:f2}%");
Console.WriteLine($"{1.0 * p5 / inputCount * 100:f2}%");


