int expectedSum = int.Parse(Console.ReadLine());

double moneyCollected = 0;

double sumCS = 0;
int counterCS = 0;
double sumCC = 0;
int counterCC = 0;
int counter = 0;
bool allCollected = false;
string input = Console.ReadLine();

while (input != "End" )
{
    double itemPrice = double.Parse(input);


    if (counter % 2 == 0)
    {
        if (itemPrice > 100)
        {
            //invalidTransaction = true;
            Console.WriteLine($"Error in transaction!");
            counter++;
        }
        else
        {
            sumCS += itemPrice;
            moneyCollected += itemPrice;
            counter++;
            counterCS++;
            Console.WriteLine($"Product sold!");
        }
       
    }
    else
    {
        if (itemPrice < 10)
        {
            //invalidTransaction = true;
            Console.WriteLine($"Error in transaction!");
            counter++;
        }
        else
        {
            sumCC += itemPrice;
            moneyCollected += itemPrice;
            counter++;
            counterCC++;
            Console.WriteLine($"Product sold!");

        }
      
    }

    if (moneyCollected >= expectedSum)
    {
        allCollected = true;
        break;
    }
    input = Console.ReadLine();
}

double averageCS = sumCS / counterCS;
double averageCC = sumCC / counterCC;

if (allCollected)
{
    Console.WriteLine($"Average CS: {averageCS:f2}"); 
    Console.WriteLine($"Average CC: {averageCC:f2}");
}
else if (input == "End")
{
    Console.WriteLine($"Failed to collect required money for charity.");
}
