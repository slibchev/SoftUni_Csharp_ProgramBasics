using System.Drawing;

string figure = Console.ReadLine();


if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    double S = Math.Pow(side, 2);
    Console.WriteLine($"{S:f3}");

}
else if (figure == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    double S = sideA * sideB;
    Console.WriteLine($"{S:f3}");
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double S = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine($"{S:f3}");
}
else if (figure == "triangle")
{
    double Sidetriangle = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double S = Sidetriangle * h / 2;
    Console.WriteLine($"{S:f3}");
}