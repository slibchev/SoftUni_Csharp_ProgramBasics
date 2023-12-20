int students = int.Parse(Console.ReadLine());

double gradeSum = 0;
double topStudent = 0;
double goodStudent = 0;
double middStudent = 0;
double failStudent = 0;

for (int i = 0; i < students; i++)
{
    double studentGrade = double.Parse(Console.ReadLine());

    if (studentGrade >= 5)
    {
        topStudent++;
        gradeSum += studentGrade;
    }
    else if(studentGrade >= 4 && studentGrade <= 4.99)
    {
        goodStudent++;
        gradeSum += studentGrade;
    }
    else if (studentGrade >= 3 && studentGrade <= 3.99)
    {
        middStudent++;
        gradeSum += studentGrade;
    }
    else if (studentGrade >= 2 && studentGrade <= 2.99)
    {
        failStudent++;
        gradeSum += studentGrade;
    }


}

double averageGrade = gradeSum / students;


Console.WriteLine($"Top students: {topStudent/students * 100:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {goodStudent/students*100:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {middStudent/students*100:f2}%");
Console.WriteLine($"Fail: {failStudent/students*100:f2}%");
Console.WriteLine($"Average: {averageGrade:f2}");

