int numberOfPenPackege = int.Parse(Console.ReadLine());
int numberOfMArkerPackege = int.Parse(Console.ReadLine());
int littersOfDetergent = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine())/100;

double penPackagePrice = 5.80;
double markerPackagePrice = 7.20;
double detergentPrice = 1.20;

double sum = (numberOfPenPackege * penPackagePrice) + (numberOfMArkerPackege * markerPackagePrice) + (littersOfDetergent * detergentPrice);
double moneyNeeded = sum - (sum * discount);

Console.WriteLine(moneyNeeded);