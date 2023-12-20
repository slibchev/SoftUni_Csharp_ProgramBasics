char startChar = char.Parse(Console.ReadLine());
char endChar = char.Parse(Console.ReadLine());
char wrongChar = char.Parse(Console.ReadLine());

int counter = 0;

for (char i = startChar; i <= endChar; i++)
{
    if(i == wrongChar)
    {
       
        continue;
    }
    for (char j = startChar; j <= endChar; j++)
    {
        if (j == wrongChar)
        {
           
            continue;
        }

        for (char k = startChar; k <= endChar; k++)
        {
            if (k == wrongChar)
            {
               
                continue;
            }

            Console.Write($"{i}{j}{k} ");
            counter++;


        }
    }


}
Console.Write(counter);
