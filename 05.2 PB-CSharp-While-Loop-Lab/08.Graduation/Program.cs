string name = Console.ReadLine();

double gradeSum = 0;
int grade = 1;
double badGrade = 0;

while (grade <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());

    if (currentGrade >= 4.00)
    {
        gradeSum += currentGrade;
        grade++;
    }
    else if (currentGrade < 4)
    {
        badGrade++;
        if (badGrade >= 2)
        {
            Console.WriteLine($"{name} has been excluded at {grade} grade");
            break;
        }

    }




}

if (grade > 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {gradeSum /12:f2}");
}

