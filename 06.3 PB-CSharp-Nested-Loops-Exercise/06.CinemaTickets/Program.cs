string movieName = Console.ReadLine();

double totalTickets = 0;
double studentTicketsCounter = 0;
double standartTicketCounter = 0;
double kidTicketCounter = 0;

while (movieName != "Finish")
{

    int seats = int.Parse(Console.ReadLine());
    double currentTickets = 0;


    for (int i = seats; i > 0; i--)
    {
        string ticketType = Console.ReadLine();


        if (ticketType == "student")
        {
            studentTicketsCounter++;
        }
        else if (ticketType == "standard")
        {
            standartTicketCounter++;
        }
        else if (ticketType =="kid")
        {
            kidTicketCounter++;
        }
        else if (ticketType == "End")
        {
            break;
        }

        totalTickets++;
        currentTickets++;

    }

    Console.WriteLine($"{movieName} - {currentTickets / seats * 100:F2}% full.");

    currentTickets = 0;
    movieName = Console.ReadLine();

}

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{studentTicketsCounter / totalTickets * 100:F2}% student tickets.");
Console.WriteLine($"{standartTicketCounter / totalTickets * 100:F2}% standard tickets.");
Console.WriteLine($"{kidTicketCounter / totalTickets * 100:F2}% kids tickets.");



