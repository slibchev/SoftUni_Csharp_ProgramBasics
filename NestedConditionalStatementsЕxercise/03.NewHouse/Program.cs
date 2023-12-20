string flowersType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

//bool correctFlower = flowersType == "Roses" || flowersType == "Dahlias"
//    || flowersType == "Tulips" || flowersType == "Narcissus" || flowersType == "Gladiolus";
double finalPrice = 0;


if (flowersType == "Roses")
{
    finalPrice = flowersCount * 5.0;

    if (flowersCount > 80)

        finalPrice = finalPrice - finalPrice * 0.1;
}
else if (flowersType == "Dahlias")
{
    finalPrice = flowersCount * 3.80;

    if (flowersCount > 90)

        finalPrice = finalPrice - finalPrice * 0.15;
}
else if (flowersType == "Tulips")
{
    finalPrice = flowersCount * 2.80;

    if (flowersCount > 80)

        finalPrice = finalPrice - finalPrice * 0.15;
}
else if (flowersType == "Narcissus")
{
    finalPrice = flowersCount * 3.0;

    if (flowersCount < 120)

        finalPrice = finalPrice + finalPrice * 0.15;
}
else if (flowersType == "Gladiolus")
{
    finalPrice = flowersCount * 2.50;

    if (flowersCount < 80)

        finalPrice = finalPrice + finalPrice * 0.2;
}

if (budget >= finalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} " +
        $"and {budget - finalPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
}

