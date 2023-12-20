int cakeLenth = int.Parse(Console.ReadLine());
int cakeWidth = int.Parse(Console.ReadLine());

int piecesOfCake = cakeLenth * cakeWidth;


while (piecesOfCake > 0)
{

    string input = Console.ReadLine();

    if (input == "STOP" && piecesOfCake > 0)
    {
        Console.WriteLine($"{piecesOfCake} pieces are left.");
        return;
    }

    int piecesTaken = int.Parse(input);


     piecesOfCake -= piecesTaken;



}

if (piecesOfCake <= 0)
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesOfCake)} pieces more.");
}
