int days = int.Parse(Console.ReadLine());

int treatedPatients = 0;
int untreatedPatients = 0;
int doctors = 7;

for (int currentDay = 1; currentDay <= days; currentDay++)
{
    if (currentDay % 3 == 0)
    {
        if ( untreatedPatients > treatedPatients)
        {
            doctors++;
        }
    }

    int DailyPatients = int.Parse(Console.ReadLine());
    
    if (DailyPatients > doctors)
    {
        untreatedPatients += DailyPatients - doctors;
        treatedPatients += doctors;
    }
    else
    {
        treatedPatients += DailyPatients;
    }

        

}
Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");