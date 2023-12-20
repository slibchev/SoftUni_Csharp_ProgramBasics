string typeOfProjection = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int colums = int.Parse(Console.ReadLine());

int income = rows * colums;

                        // Variation 1

//switch (typeOfProjection)
//{
//	case "Premiere":
//        Console.WriteLine($"{income * 12.00:f2} leva , income.");
//        break;
//    case "Normal":
//        Console.WriteLine($"{income * 7.50:f2} leva , income.");
//        break;
//    case "Discount":
//        Console.WriteLine($"{income * 5.00:f2} leva , income.");
//        break;


//}

                        // Variation 2

switch (typeOfProjection)
{
    case "Premiere":
        Console.WriteLine("{0:f2}, leva", income * 12.00);
        break;
    case "Normal":
        Console.WriteLine("{0:f2}, leva ", income * 7.50);
        break;
    case "Discount":
        Console.WriteLine("{0:f2} leva" , income * 5.0);
        break;


}