int n = int.Parse(Console.ReadLine());

int spaceCounter = (n - 1) / 2;
string symbolEven = "**";
string symbolOdd = "*";

for (int row = 0; row < (n - 1 ) / 2; row++)
{

    if (n % 2 == 0)
    {
        Console.Write( new string ('-',spaceCounter));
        Console.Write(symbolEven);
        Console.Write(new string('-',spaceCounter));
        symbolEven += "**";
        spaceCounter --;
        
    }
    else
    {
        Console.Write(new string('-', spaceCounter));
        Console.Write(symbolOdd);
        Console.Write(new string('-', spaceCounter));
        symbolOdd += "**";
        spaceCounter--;

    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    Console.Write("*");
}

Console.WriteLine();

for (int row = 0; row < n  / 2; row++)
{
    Console.Write('|');
    Console.Write(new string('*', n - 2));
    Console.Write('|');
    Console.WriteLine();

}

