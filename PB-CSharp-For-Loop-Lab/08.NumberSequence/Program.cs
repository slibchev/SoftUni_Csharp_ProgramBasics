﻿int n = int.Parse(Console.ReadLine());

int minNum = int.MaxValue;
int maxNum = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum < minNum)
    {
        minNum = currentNum;

    }
    
    if (currentNum > maxNum) 
    {
        maxNum = currentNum;
    }
}
Console.WriteLine($"Max number: {maxNum}");
Console.WriteLine($"Min number: {minNum}");