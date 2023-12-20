
int goal = 10000;
int stepCounter = 0;

while (stepCounter < goal)
{
    string input = Console.ReadLine();

    if (input != "Going home")
    {
        int currentSteps = int.Parse(input);
        stepCounter += currentSteps;

    }
    else if (input == "Going home")
    {
        int homeSteps = int.Parse(Console.ReadLine());
        stepCounter += homeSteps;
        break;
    }

}

if (stepCounter >= goal)
{
    Console.WriteLine($"Goal reached! Good job!");
    Console.WriteLine($"{stepCounter - goal} steps over the goal!");
}
else
{
    Console.WriteLine($"{goal - stepCounter} more steps to reach goal.");
}
