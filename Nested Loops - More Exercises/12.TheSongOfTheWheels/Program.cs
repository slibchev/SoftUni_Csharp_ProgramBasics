using System.Diagnostics.Metrics;

int M = int.Parse(Console.ReadLine());

int counter = 0;
bool noCombination = true;
bool password = false;
string passWord = "";


for (int a = 1; a <= 9; a++)
{
    for (int b = 1; b <= 9; b++)
    {
        for (int c = 1; c <= 9; c++)
        {
            for (int d = 1; d <= 9; d++)
            {
                if (a * b + c * d == M && a < b && c > d)
                {
                    noCombination = false;

                    Console.Write($"{a}{b}{c}{d} ");

                    counter++;

                    if ( counter  == 4)
                    {
                        password = true;
                        passWord = $"{a}{b}{c}{d} ";
                    }

                    //if (noPassword)
                    //{
                    //    Console.WriteLine();
                    //    Console.Write($"No!");
                    //}
                    
                   
                }
                
            }
        }
    }
}
if (password)
{
    Console.WriteLine();
    Console.Write($"Password: {passWord}");
    return;
}

if (noCombination)
{
    Console.WriteLine();
    Console.Write($"No!");
    return;
}

Console.WriteLine();
Console.Write($"No!");






