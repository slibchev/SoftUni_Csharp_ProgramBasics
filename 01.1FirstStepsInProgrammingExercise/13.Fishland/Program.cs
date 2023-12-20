double skumriqPrice = double.Parse(Console.ReadLine());
double cacaPrice = double.Parse(Console.ReadLine());
double palamudKilograms = double.Parse(Console.ReadLine());
double safridKilograms = double.Parse(Console.ReadLine());
int midiKilograms = int.Parse(Console.ReadLine());

double palamudPrice = skumriqPrice + skumriqPrice * 0.6;
double safridPrice = cacaPrice + cacaPrice * 0.8;
double midiPrice = 7.50;

double moneyNeeded = (palamudPrice * palamudKilograms) + (safridPrice * safridKilograms) + (midiKilograms * midiPrice);


Console.WriteLine($"{moneyNeeded:f2}");