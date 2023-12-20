int bookPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysLimitToRead  = int.Parse(Console.ReadLine());

int totalHoursToRead = bookPages / pagesPerHour;
int hoursPerDayToRead = totalHoursToRead / daysLimitToRead;



Console.WriteLine($"{hoursPerDayToRead}");