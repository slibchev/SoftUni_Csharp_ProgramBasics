int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

double totalTime = firstTime + secondTime + thirdTime;
double minutes = totalTime / 60;
double seconds = totalTime % 60;

if (seconds < 10)
{
    Console.WriteLine($"{Math.Floor(minutes)}:0{seconds}");
}
else
{
    Console.WriteLine($"{Math.Floor(minutes)}:{seconds}");
}

//double totalTme = firstTime + secondTime + thirdTime;
//double hours = totalTme / 3600;
//double minutes = totalTme / 60;
//double seconds = totalTme % 60;

//if (minutes >= 60)
//{
//    minutes = 0;
//}

//if (seconds < 10)
//{
//    Console.WriteLine($"{Math.Floor(hours)}:{Math.Floor(minutes)}:0{seconds}");
//}
//else if (seconds < 10 && minutes < 10)
//{
//    Console.WriteLine($"{Math.Floor(hours)}:0{Math.Floor(minutes)}:0{seconds}");
//}
//else
//{
//    Console.WriteLine($"{Math.Floor(hours)}:{Math.Floor(minutes)}:{seconds}");
//}
