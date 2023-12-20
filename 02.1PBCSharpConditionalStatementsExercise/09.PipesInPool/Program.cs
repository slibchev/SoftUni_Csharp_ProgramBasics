int poolVolume = int.Parse(Console.ReadLine());
int Pipe1Debit  = int.Parse(Console.ReadLine());
int Pipe2Debit  = int.Parse(Console.ReadLine());    
double hourse = double.Parse(Console.ReadLine());

double Pipe1Liters = Pipe1Debit * hourse;
double Pipe2Liters = Pipe2Debit * hourse;
double poolLevelPercent =  (Pipe1Liters +  Pipe2Liters) / poolVolume * 100;
double poolLEvelLiters = poolLevelPercent * poolVolume / 100;
double Pipe1Percent = Pipe1Liters / poolLEvelLiters * 100;
double Pipe2Percent = Pipe2Liters / poolLEvelLiters * 100;

if ( poolLEvelLiters > poolVolume)
{
    Console.WriteLine($"For {hourse} hours the pool overflows with " +
        $"{poolLEvelLiters - poolVolume:f2} liters.");
}
else
{
    Console.WriteLine($"The pool is {poolLevelPercent:f2}% full. Pipe 1:" +
    $" {Pipe1Percent:f2}%. Pipe 2: {Pipe2Percent:f2}%.");
}

