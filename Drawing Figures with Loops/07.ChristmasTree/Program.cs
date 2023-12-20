int n = int.Parse(Console.ReadLine());



Console.Write(new string(' ', n+1));
Console.Write("|");
Console.WriteLine();


for (int row = 1; row <= n; row++)
{
    
    Console.Write(new string(' ', n - row));
    Console.Write(new string('*', row));
    Console.Write(new string(" | "));
    Console.Write(new string('*', row));
    Console.WriteLine();
}
