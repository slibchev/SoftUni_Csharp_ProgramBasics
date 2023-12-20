double budget = double.Parse(Console.ReadLine());
int persons = int.Parse(Console.ReadLine());
double ClothesPricePerPerson = double.Parse(Console.ReadLine());


double decoration = budget * 0.1;
double totalClothesPrice = persons * ClothesPricePerPerson;

if (persons > 150)
{
    totalClothesPrice = totalClothesPrice * 0.9;
}
double totalCost = totalClothesPrice + decoration;

if (budget < totalCost)
{
    Console.WriteLine($"Not enough money!");
    Console.WriteLine($"Wingard needs {totalCost - budget:f2} leva more.");
}
else if (totalCost <= budget)
{
    Console.WriteLine($"Action!");
    Console.WriteLine($"Wingard starts filming with {budget - totalCost:f2} leva left.");
}