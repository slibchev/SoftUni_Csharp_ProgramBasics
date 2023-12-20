double vacationPrice = double.Parse(Console.ReadLine());
int puzzle = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int teddyBears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double puzzlePrice = 2.60 * puzzle;
double dollsPrice = 3 * dolls;
double teddyBearsPrice = 4.10 * teddyBears;
double minionsPrice = 8.20 * minions;
double trucksPrice = 2 * trucks;

int toysCount = puzzle + dolls + teddyBears + minions + trucks;
double income = puzzlePrice + dollsPrice + teddyBearsPrice + minionsPrice + trucksPrice;

if (toysCount >= 50)
{
    income = income - income * 0.25;
}

income = income - income * 0.1;

if (income >= vacationPrice)
{
    Console.WriteLine($"Yes! {income - vacationPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {Math.Abs(income - vacationPrice):f2} lv needed.");
}

