int numberOfPackegesDogs = int.Parse(Console.ReadLine());
int numberOfPackegesCats = int.Parse(Console.ReadLine());

double dogFoodPrice = numberOfPackegesDogs * 2.5;
double catFoodPrice = numberOfPackegesCats *4;

double finalSum = dogFoodPrice + catFoodPrice;

Console.WriteLine($"{finalSum} lv.");

