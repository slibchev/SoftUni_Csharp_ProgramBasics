int plasticCover = int.Parse(Console.ReadLine());
int paintVolume = int.Parse(Console.ReadLine());
int deluterVolume = int.Parse(Console.ReadLine());
int workingHours = int.Parse(Console.ReadLine());
double totalExpenditure;
double extraPaint = (paintVolume * 0.1) * 14.50;

double plasticCoverPrice = 1.5;
double paintPrice = 14.50;
double paintDeluterPrice = 5;
double plasticBagsPrice = 0.40;
double extraPlasticCover = 2 * plasticCoverPrice;

totalExpenditure = (plasticCover * plasticCoverPrice + extraPlasticCover) + (paintVolume * paintPrice + extraPaint) + (deluterVolume * paintDeluterPrice) + plasticBagsPrice;
double workersCost = workingHours * (totalExpenditure * 0.3);
double totalCost = totalExpenditure + workersCost;

Console.WriteLine(totalCost);

 