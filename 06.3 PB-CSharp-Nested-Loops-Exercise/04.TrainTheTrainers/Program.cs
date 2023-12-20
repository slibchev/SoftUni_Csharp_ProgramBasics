int juryMembers = int.Parse(Console.ReadLine());
string presentation = Console.ReadLine();

double sumGrade = 0;
int currentGradeCounter = 0;
double presentAverage;
double totalAverage = 0;
int presentCounter = 0;

while (presentation != "Finish")
{
    presentCounter++;

    for (int i = 1; i <= juryMembers; i++)
    {
        double currentGrade = double.Parse(Console.ReadLine());

        sumGrade += currentGrade;
        currentGradeCounter++;
        


    }
    presentAverage = sumGrade / currentGradeCounter;
    totalAverage += presentAverage;

    Console.WriteLine($"{presentation} - {presentAverage:f2}.");

    sumGrade = 0;
    currentGradeCounter = 0;


    
    presentation = Console.ReadLine();
}

Console.WriteLine($"Student's final assessment is {totalAverage / presentCounter:f2}.");
