int input = int.Parse(Console.ReadLine());

int sum = 0;
int maxNum = int.MinValue;


for (int i = 0; i < input; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    sum += currentNum;

    if (currentNum > maxNum)
    {
        maxNum = currentNum;
    }
  

}

double sumClean = Math.Abs(maxNum - sum);

if (maxNum == sumClean)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(maxNum - sumClean)}");
}
