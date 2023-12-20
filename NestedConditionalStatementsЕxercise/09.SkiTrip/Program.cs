int days = int.Parse(Console.ReadLine());   
string roomType = Console.ReadLine();
string feedback = Console.ReadLine();


double roomPrice = 18.00 * (days - 1);
double apartmentPrice = 25.00 * (days - 1);
double presidentApartment = 35.00 * (days -1);

double roomFinalPrice = 0;
double apartmentFinalPrice = 0;
double presidentFinalPrice = 0;
double anyRoomFinalPrice = 0;

if (days < 10)
{
    switch (roomType)
    {
        case "room for one person":
            roomFinalPrice = roomPrice;
            anyRoomFinalPrice += roomFinalPrice;
            break;
        case "apartment":
            apartmentFinalPrice = apartmentPrice * 0.7;
            anyRoomFinalPrice += apartmentFinalPrice;
            break;
        case "president apartment":
            presidentFinalPrice = presidentApartment * 0.9;
            anyRoomFinalPrice += presidentFinalPrice;
            break;
    }
    
    
}
else  if (days >= 10 &&  days <= 15)
{
    switch (roomType)
    {
        case "room for one person":
            roomFinalPrice = roomPrice;
            anyRoomFinalPrice += roomFinalPrice;
            break;
        case "apartment":
            apartmentFinalPrice = apartmentPrice * 0.65;
            anyRoomFinalPrice += apartmentFinalPrice;
            break;
        case "president apartment":
            presidentFinalPrice = presidentApartment * 0.85;
            anyRoomFinalPrice += presidentFinalPrice;
            break;
    }
}
else
{
    switch (roomType)
    {
        case "room for one person":
            roomFinalPrice = roomPrice;
            anyRoomFinalPrice += roomFinalPrice;
            break;
        case "apartment":
            apartmentFinalPrice = apartmentPrice * 0.5;
            anyRoomFinalPrice += apartmentFinalPrice;
            break;
        case "president apartment":
            presidentFinalPrice = presidentApartment * 0.8;
            anyRoomFinalPrice += presidentFinalPrice;
            break;
    }
}

if (feedback == "positive")
{
    anyRoomFinalPrice = anyRoomFinalPrice + anyRoomFinalPrice * 0.25;
}
else
{
    anyRoomFinalPrice = anyRoomFinalPrice - anyRoomFinalPrice * 0.1;
}

Console.WriteLine($"{anyRoomFinalPrice:f2}");
