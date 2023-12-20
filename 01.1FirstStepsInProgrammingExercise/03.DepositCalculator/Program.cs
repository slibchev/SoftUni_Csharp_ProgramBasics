
double depostiSum = double.Parse(Console.ReadLine());
int depositTime = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double Monthlyinterest = (depostiSum * annualInterestRate / 12) / 100;
double totalInterest = depositTime * Monthlyinterest;
double totalSum = depostiSum + totalInterest;


Console.WriteLine($"{totalSum}");