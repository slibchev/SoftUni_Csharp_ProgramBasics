//double ceCelsius = double.Parse(Console.ReadLine());
double fahrenheit = double.Parse(Console.ReadLine());

//double fahrenheit = ceCelsius * 1.8 + 32;
double ceCelsius = (fahrenheit - 32) * 0.5555;

//Console.WriteLine($"{fahrenheit:f2}");
Console.WriteLine($"{ceCelsius:f2}");
