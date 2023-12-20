int basketballTax = int.Parse(Console.ReadLine());

double shoes = basketballTax - basketballTax * 0.4;
double clothes = shoes - shoes * 0.2;
double basketball = clothes * 0.25;
double accessories = basketball * 0.2;

double totalExpenditure = basketballTax + shoes + clothes + basketball + accessories;

Console.WriteLine(totalExpenditure);