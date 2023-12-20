
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int hight = int.Parse(Console.ReadLine());


int spaceLeft = width * length * hight;


while (spaceLeft > 0)
{
    string input = Console.ReadLine();

    if (input == "Done" && spaceLeft > 0)
    {
        Console.WriteLine($"{spaceLeft} Cubic meters left.");
        return;
    }
    else 
    {
        int boxes = int.Parse(input);
        spaceLeft -= boxes;
    }

}


if (spaceLeft <= 0)
{
    Console.WriteLine($"No more free space! You need {Math.Abs(spaceLeft)} Cubic meters more.");
}
