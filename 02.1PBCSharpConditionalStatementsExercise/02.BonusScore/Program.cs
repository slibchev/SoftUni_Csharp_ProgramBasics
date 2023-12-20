int inputNumber = int.Parse(Console.ReadLine());

double bonusPoint = 0;
double extraBonusPoint = 0;
bool isEven = inputNumber % 2 == 0;
bool onFive = inputNumber % 10 == 5;
bool isOdd = inputNumber % 2 != 0;



if (inputNumber <= 100)
{
    if (isEven)
    {
        bonusPoint += 5;
        extraBonusPoint++;
    }
    else if (onFive)
    {
        bonusPoint += 5;
        extraBonusPoint += 2;
    }
    else if (isOdd)
    {
        bonusPoint += 5; 
    }

}
else if (inputNumber > 100 &&  inputNumber <= 1000)
{
    if (isEven)
    {
        bonusPoint += inputNumber * 0.2;
        extraBonusPoint++;
    }
    else if (onFive)
    {
        bonusPoint += inputNumber * 0.2;
        extraBonusPoint += 2;
    }
    else if (isOdd)
    {
        bonusPoint += inputNumber * 0.2;  
    }
    
}
else if (inputNumber > 1000)
{
    if (isEven)
    {
        bonusPoint += inputNumber * 0.1;
        extraBonusPoint++;
    }
    else if (onFive)
    {
        bonusPoint += inputNumber * 0.1;
        extraBonusPoint += 2;
    }
    else if (isOdd)
    {
        bonusPoint += inputNumber * 0.1; 
    }

}
double totalBonusPoints = bonusPoint + extraBonusPoint;

Console.WriteLine(totalBonusPoints);
Console.WriteLine(inputNumber + totalBonusPoints);


