int hoursOfExam = int.Parse(Console.ReadLine());
int minutesOfExam = int.Parse(Console.ReadLine());
int hoursOfArrival = int.Parse(Console.ReadLine());
int minutesOfArrival = int.Parse(Console.ReadLine());

double examInMinutes = hoursOfExam * 60 + minutesOfExam;
double arrivalInMinutes = hoursOfArrival * 60 + minutesOfArrival;
double differenceInMinutes = Math.Abs(examInMinutes - arrivalInMinutes);
double differenceInMinutesModul = differenceInMinutes % 60;
double hoursDifference = Math.Abs(hoursOfExam - hoursOfArrival);

if (examInMinutes == arrivalInMinutes)
{
    Console.WriteLine("On time");
}
else if (examInMinutes > arrivalInMinutes)
{
    if (differenceInMinutes <= 30)
    {
        Console.WriteLine("On time");
        Console.WriteLine($"{differenceInMinutesModul} minutes before the start");
    }
    else if (differenceInMinutes < 60)
    {
        Console.WriteLine("Early");
        Console.WriteLine($"{differenceInMinutesModul} minutes before the start");
    }
    else if (differenceInMinutes >= 60 && differenceInMinutesModul < 10)
    {
        Console.WriteLine("Early");
        Console.WriteLine($"{hoursDifference}:0{differenceInMinutesModul} hours before the start ");
    }
    else if (differenceInMinutes >= 60 && differenceInMinutesModul >= 10)
    {
        Console.WriteLine("Early");
        Console.WriteLine($"{hoursDifference}:{differenceInMinutesModul} hours before the start");
    }

}
else if (examInMinutes < arrivalInMinutes)
{

    if (differenceInMinutes < 60)
    {
        Console.WriteLine("Late");
        Console.WriteLine($"{differenceInMinutesModul} minutes after the start");
    }
    else if (differenceInMinutes >= 60 && differenceInMinutesModul < 10)
    {
        Console.WriteLine("Late");
        Console.WriteLine($"{hoursDifference}:0{differenceInMinutesModul} hours after the start ");
    }
    else if (differenceInMinutes >= 60 && differenceInMinutesModul >= 10)
    {
        Console.WriteLine("Late");
        Console.WriteLine($"{hoursDifference}:{differenceInMinutesModul} hours after the start");
    }
}

