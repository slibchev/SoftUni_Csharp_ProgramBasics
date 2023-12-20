int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());


                                    //Version 1

double resultPlus = n1 + n2;
double resultMinus = n1 - n2;
double resultMulti = n1 * n2;


switch (symbol)
{
    case '+':
        if (resultPlus % 2 == 0)
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {resultPlus} - even");
        }
        else
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {resultPlus} - odd");
        }
        break;

    case '-':
        if (resultMinus % 2 == 0)
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {resultMinus} - even");
        }
        else
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {resultMinus} - odd");
        }
        break;

    case '*':
        if (resultMulti % 2 == 0)
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {resultMulti} - even");
        }
        else
        {
            Console.WriteLine($"{n1} {symbol} {n2} = {resultMulti} - odd");
        }
        break;

    case '/':
        if (n1 == 0 || n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            double resultDevision = (double)n1 / n2;
            Console.WriteLine($"{n1} {symbol} {n2} = {resultDevision:f2}");
        }
        break;

    case '%':
        if (n1 == 0 || n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            double resultModulDev = n1 % n2;
            Console.WriteLine($"{n1} {symbol} {n2} = {resultModulDev}");
        }
        break;

}

//Version 2

//bool PlusMinusMultiply = symbol == '+' || symbol == '-' || symbol == '*';
//bool divisionModulDivision = symbol == '/' || symbol == '%';

//if (PlusMinusMultiply)
//{
//    if (n1 + n2 % 2 == 0 || n1 - n2 % 2 == 0 || n1 * n2 % 2 == 0)
//    {
//        switch (symbol)
//        { 
//            case '+':
//                Console.WriteLine($"{n1} {symbol} {n2} = {n1 + n2} - even");

//                break;

//            case '-':
//                Console.WriteLine($"{n1} {symbol} {n2} = {n1 - n2} - even");
//                break;

//            case '*':
//                Console.WriteLine($"{n1} {symbol} {n2} = {n1 * n2} - even");
//                break;
//        }

//    }
//    else if (n1 + n2 % 2 != 0 || n1 - n2 % 2 != 0 || n1 * n2 % 2 != 0)
//    {
//        switch (symbol)
//        {
//            case '+':
//                Console.WriteLine($"{n1} {symbol} {n2} = {n1 + n2} - odd");

//                break;

//            case '-':
//                Console.WriteLine($"{n1} {symbol} {n2} = {n1 - n2} - odd");
//                break;

//            case '*':
//                Console.WriteLine($"{n1} {symbol} {n2} = {n1 * n2} - odd");
//                break;
//        }

//    }
//}
//else if (divisionModulDivision)
//{
//    if (n1 == 0 || n2 == 0)
//    {
//        Console.WriteLine($"Cannot divide {n1} by zero");
//    }
//    else if (symbol == '/')
//    {
//        Console.WriteLine($"{n1} {symbol} {n2} = {n1 / n2:f2}");
//    }
//    else if (symbol == '%')
//    {
//        Console.WriteLine($"{n1} {symbol} {n2} = {n1 % n2}");
//    }

//}

