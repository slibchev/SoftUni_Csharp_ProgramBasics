int juniorCount = int.Parse(Console.ReadLine());
int seniorCount = int.Parse(Console.ReadLine());
string terrenType = Console.ReadLine();


double income = 0;

if (terrenType == "trail")
{
    income = juniorCount * 5.5 + seniorCount * 7;

}
else if (terrenType == "cross-country")
{
    income = juniorCount * 8 +  seniorCount * 9.50;

    if(juniorCount + seniorCount >= 50)
    {
        income = income * 0.75;
    }
}
else if(terrenType == "downhill")
{
    income = juniorCount * 12.25 + seniorCount * 13.75;
}
else if (terrenType == "road")
{
    income = juniorCount * 20 + seniorCount * 21.50;
}

double companyTax = income * 0.05;
double donatedSum = income - companyTax;

Console.WriteLine($"{donatedSum:f2}");





