int months = int.Parse(Console.ReadLine());

double electricityBill = 0;
double waterBill = 0;
double internetBill = 0;
double OtherBill = 0;


for (int i = 0; i < months; i++)
{
    
    //double monthlyelEctricityBill = 0;
    double monthlyWaterBill = 20;
    double monthlyInternetBill = 15;

    double electricity = double.Parse(Console.ReadLine());

    waterBill += monthlyWaterBill;
    internetBill += monthlyInternetBill;
    electricityBill += electricity;

    double monthlySum = electricity + monthlyWaterBill + monthlyInternetBill;
    double monthlyOtherBill = monthlySum   * 1.2;
    OtherBill += monthlyOtherBill;

}

double averageBill = (electricityBill + waterBill + internetBill + OtherBill) / months;

Console.WriteLine($"Electricity: {electricityBill:f2} lv");
Console.WriteLine($"Water: {waterBill:f2} lv");
Console.WriteLine($"Internet: {internetBill:f2} lv");
Console.WriteLine($"Other: {OtherBill:f2} lv");
Console.WriteLine($"Average: {averageBill:f2} lv");