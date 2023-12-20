double deGreece = double.Parse(Console.ReadLine());

if (deGreece >= 26.00 && deGreece  <= 35.00)
{
    Console.WriteLine("Hot");
}
else if (deGreece >=20.1 && deGreece <= 25.9)
{
    Console.WriteLine("Warm");
}
else if (deGreece >=15.00 && deGreece <= 20.00)
{
    Console.WriteLine("Mild");
}
else if (deGreece >=12.00 &&  deGreece <= 14.9)
{
    Console.WriteLine("Cool");
}
else if (deGreece >= 5.00 && deGreece <= 11.9)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("unknown");
}
