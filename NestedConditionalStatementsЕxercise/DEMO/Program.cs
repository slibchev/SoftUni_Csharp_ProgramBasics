int hrizantemaCount = int.Parse(Console.ReadLine());
int rosesCount = int.Parse(Console.ReadLine());
int tulipsCount = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string dayType = Console.ReadLine();

double hrizantemaPrice = 0;
double rosesPrice = 0;
double tulipPrice = 0;
int allFlowersCount = hrizantemaCount + rosesCount + tulipsCount;
int bucketPaper = 2;
double priceIncrese = 0;


if (season == "Spring" || season == "Summer")
{
    hrizantemaPrice = hrizantemaCount * 2;
    rosesPrice = rosesCount * 4.10; ;
    tulipPrice = tulipsCount * 2.50;

    if (dayType == "Y")
    {
        priceIncrese = 0.15;
    }
}
else if (season =="Autumn" || season == "Winter")
{
    hrizantemaPrice = hrizantemaCount * 3.75;
    rosesPrice = rosesCount * 4.50; ;
    tulipPrice = tulipsCount * 4.15;

    if (dayType == "Y")
    {
        priceIncrese = 0.15;

    }
}

double allFlowerPriceN = hrizantemaPrice + rosesPrice + tulipPrice;
double allFlowerPriceY = allFlowerPriceN + allFlowerPriceN * priceIncrese;
double discount1= 0;
double discount2= 0;
double discount3= 0;

  if (season == "Spring" && tulipsCount > 7)
    {
        discount1 += 0.05;
    }
   if (season == "Winter" && rosesCount >= 10)
    {
    discount2 += 0.1;
    }
   if (allFlowersCount > 20)
    {
    discount3 += 0.2;
    }

double bucketPrice = 0;

 if (dayType == "Y")
{
    bucketPrice = allFlowerPriceY - (allFlowerPriceY * discount1) - 
        (allFlowerPriceY * discount2) -(allFlowerPriceY * discount3);
}
 else if (dayType == "N")
{
    bucketPrice = allFlowerPriceN - (allFlowerPriceN * discount1) -
        (allFlowerPriceN * discount2) - (allFlowerPriceN * discount3);
}





Console.WriteLine($"{bucketPrice + bucketPaper:f2}");