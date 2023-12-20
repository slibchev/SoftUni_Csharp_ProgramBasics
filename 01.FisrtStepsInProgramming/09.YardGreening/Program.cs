double areaForWork = double.Parse(Console.ReadLine());
double pricePerSquareMeter = 7.61;
double finalPrice = areaForWork * pricePerSquareMeter;
double discount = finalPrice * 0.18;

Console.WriteLine($"The final price is: {finalPrice - discount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");



