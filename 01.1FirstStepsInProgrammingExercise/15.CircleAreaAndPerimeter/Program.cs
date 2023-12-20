double r = double.Parse(Console.ReadLine());

double P = 2 * (Math.PI) * r;
double S = Math.Pow(r, 2) * Math.PI;
Console.WriteLine($"{P:f2}");
Console.WriteLine($"{S:f2}");
