
int n = int.Parse(Console.ReadLine());

double leftSum = 0;
double rightSum = 0;

for (int i = 1; i <= n; i++)
{

    if (i % 2 != 0)
    {
        int currentNum = int.Parse(Console.ReadLine());
        leftSum += currentNum;
    }
    else
    {
        int currentNum = int.Parse(Console.ReadLine());
        {
            rightSum += currentNum;
        }
    }

}
if (leftSum == rightSum)
{
    Console.WriteLine($"Yes");
    Console.WriteLine($"Sum = {leftSum}");
}
else
{
    Console.WriteLine($"No");
    Console.WriteLine($"Diff = {Math.Abs(leftSum - rightSum)}");
}
