string TargetBook = Console.ReadLine();

string input = Console.ReadLine();
int booksChecked = 0;

while (input != TargetBook)
{


    if (input == "No More Books")
    {
        Console.WriteLine($"The book you search is not here!");
        Console.WriteLine($"You checked {booksChecked} books.");
        return;
    }
    booksChecked++;

    

    input = Console.ReadLine();


}

Console.WriteLine($"You checked {booksChecked} books and found it.");
