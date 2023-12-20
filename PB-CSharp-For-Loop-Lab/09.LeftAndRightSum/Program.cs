
int n = int.Parse(Console.ReadLine());

double leftSum = 0;
double rightSum = 0;

//for (int i = 1; i <= n * 2 ; i++)
//{

//      int currentNum = int.Parse(Console.ReadLine());
//      leftSum += currentNum;



//}
//if (leftSum == rightSum)
//{
//    Console.WriteLine($"Yes, sum = {leftSum}");
//}
//else
//{
//    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
//}

for (int i = 1; i <= n; i++)
{

    int currentNum = int.Parse(Console.ReadLine());
    leftSum += currentNum;

}

for (int i = 1;i <= n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    rightSum += currentNum;
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}