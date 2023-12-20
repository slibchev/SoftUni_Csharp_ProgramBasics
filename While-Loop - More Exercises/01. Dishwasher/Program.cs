double detergent = double.Parse(Console.ReadLine())*750;

int counter = 0;
bool noMoreDetergent = false;
int plateCounter = 0;
int potCounter = 0;

string input = Console.ReadLine();


while (input!= "End")
{
    counter++;
    int dishes = int.Parse(input);

    if (counter % 3 == 0)
    {
        potCounter += dishes;
        detergent -= dishes * 15;
    }
    else
    {
        plateCounter += dishes;
        detergent -= dishes * 5;
    }


    if (detergent < 0)
    {
        noMoreDetergent = true;
        break;
    }

    input = Console.ReadLine();

}

if (noMoreDetergent)
{
    Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
}
else
{
    Console.WriteLine($"Detergent was enough!");
    Console.WriteLine($"{plateCounter} dishes and {potCounter} pots were washed.");
    Console.WriteLine($"Leftover detergent {detergent} ml.");
}