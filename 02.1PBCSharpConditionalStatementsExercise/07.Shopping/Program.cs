double PeterBudget = double.Parse(Console.ReadLine());
int GPU = int.Parse(Console.ReadLine());
int CPU = int.Parse(Console.ReadLine());
int RAM = int.Parse(Console.ReadLine());

double GPUPrice = 250;
double GPUTotalPrice = GPU * 250;
double CPUPrice = GPUTotalPrice * 0.35;
double CPUTotalPrice = CPU * CPUPrice;
double RAMPrice = GPUTotalPrice * 0.1;
double RAMTotalPrice = RAM * RAMPrice;


double bill = GPUTotalPrice + CPUTotalPrice + RAMTotalPrice;



if (GPU > CPU)
{
    bill = bill - bill * 0.15;
}


if (PeterBudget >= bill)
{
    Console.WriteLine($"You have {PeterBudget - bill:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {bill - PeterBudget:f2} leva more!");
}
