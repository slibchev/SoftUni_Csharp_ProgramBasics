int badGrades = int.Parse(Console.ReadLine());

int currentBadGrades = 0;
double gradeSum = 0;
int numberOfProlems = 0;
string lastProblem = string.Empty;

while (currentBadGrades < badGrades)
{
    string nameOFProblem = Console.ReadLine();

    if (nameOFProblem == "Enough")
    {
        Console.WriteLine($"Average score: {gradeSum / numberOfProlems:F2}");
        Console.WriteLine($"Number of problems: {numberOfProlems}");
        Console.WriteLine($"Last problem: {lastProblem}");
        return;
    }

    int grade = int.Parse(Console.ReadLine());

    lastProblem = nameOFProblem;
    gradeSum += grade;
    numberOfProlems++;

    if (grade <= 4)
    {
        currentBadGrades++;
    }
}

Console.WriteLine($"You need a break, {currentBadGrades} poor grades.");
