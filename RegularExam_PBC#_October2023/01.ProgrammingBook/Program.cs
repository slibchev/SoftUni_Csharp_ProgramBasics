
double pagePrice = double.Parse(Console.ReadLine());
double coverPrice = double.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());
double desynerTax = double.Parse(Console.ReadLine());
int percentOfTheTeam = int.Parse(Console.ReadLine());

double allPagesPrice = pagePrice * 899;
double coversPrice = coverPrice * 2;

double bookMiddlePrice = allPagesPrice + coversPrice;

double doscountPercent = bookMiddlePrice * discount/ 100 ;

double bookMiddPrice2 = bookMiddlePrice - doscountPercent;

double bookFinalPrice = bookMiddPrice2 + desynerTax;

double teamContribution = bookFinalPrice * percentOfTheTeam / 100;

double Total = bookFinalPrice - teamContribution;

Console.WriteLine($"Avtonom should pay {Total:f2} BGN.");