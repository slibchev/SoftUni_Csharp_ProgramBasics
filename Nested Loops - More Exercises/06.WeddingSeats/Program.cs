char endSector = char.Parse(Console.ReadLine());
int rowsInFirstSector = int.Parse(Console.ReadLine());
int oddRowSeatNumber = int.Parse(Console.ReadLine());

int seatCounter = 0;

for (char sector = 'A'; sector <= endSector; sector++)
{

    for (int row = 1; row <= rowsInFirstSector; row++)
    {
        int testCounter = 0;

        if (row % 2 != 0)
        {

            for (char seat = 'a'; seat <= 'z'; seat++)
            {
                Console.WriteLine($"{sector}{row}{seat}");
                seatCounter++;
                testCounter++;

                if (testCounter == oddRowSeatNumber)
                {
                    break;
                }

            }

        }
        else
        {

            for (char seat = 'a'; seat <= 'z'; seat++)
            {
                Console.WriteLine($"{sector}{row}{seat}");
                seatCounter++;
                testCounter++;
                if (testCounter == (oddRowSeatNumber + 2))
                {
                    break;
                }
            }

        }


    }


    rowsInFirstSector++;

}
Console.WriteLine(seatCounter);
