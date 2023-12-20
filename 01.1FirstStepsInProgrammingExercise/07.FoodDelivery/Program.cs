int chickenMenuCount = int.Parse(Console.ReadLine());
int fishMenuCount = int.Parse(Console.ReadLine());
int vegeterianMenuCount = int.Parse(Console.ReadLine());
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegeterianMenuPrice = 8.15;
double menuBill = (chickenMenuCount * chickenMenuPrice) + (fishMenuCount * fishMenuPrice) + (vegeterianMenuCount * vegeterianMenuPrice);
double desert = menuBill * 0.2;
double totalBill = menuBill + desert;

Console.WriteLine(totalBill + 2.50);