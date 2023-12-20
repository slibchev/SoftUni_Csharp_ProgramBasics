double X = double.Parse(Console.ReadLine());
double Y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double houseDoor = 1.2 * 2;
double houseWindow = (1.5 * 1.5) * 2;
double sideHouseArea = (X * Y) * 2 - (houseWindow);
double frontHouseArea = (X * X) * 2 - (houseDoor);
double roofFront = ((X * h) / 2) * (2);
double roofSides = (X * Y) * 2;
double totalHouseArea = sideHouseArea + frontHouseArea;
double totalRoofArea = roofFront + roofSides;


double greenPaint = totalHouseArea / 3.4;
double redPaint = totalRoofArea / 4.3;


Console.WriteLine($"{greenPaint:f2}");
Console.WriteLine($"{redPaint:f2}");



