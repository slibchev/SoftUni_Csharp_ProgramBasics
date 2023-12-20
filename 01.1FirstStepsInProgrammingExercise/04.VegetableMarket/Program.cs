double vegetablePrice = double.Parse(Console.ReadLine());
double fruitsPrice = double.Parse(Console.ReadLine());
double vegetableKilograms = double.Parse(Console.ReadLine());
double fruitsKilograms = double.Parse(Console.ReadLine());

double profit = (vegetablePrice * vegetableKilograms)  + (fruitsPrice * fruitsKilograms);
double profitInEuro = profit / 1.94;

Console.WriteLine($"{profitInEuro:f2}");
