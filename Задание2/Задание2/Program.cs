Console.Clear();
Console.Write("Введите X1: ");
double X1 = double.Parse(Console.ReadLine() ??"");

Console.Write("Введите X2: ");
double X2 = double.Parse(Console.ReadLine() ??"");

Console.Write("Введите Y1: ");
double Y1 = double.Parse(Console.ReadLine() ??"");

Console.Write("Введите Y2: ");
double Y2 = double.Parse(Console.ReadLine()??"");

Console.Write("Введите Z1: ");
double Z1 = double.Parse(Console.ReadLine()??"");

Console.Write("Введите Z2: ");
double Z2 = double.Parse(Console.ReadLine()??"");

double distance = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1) + (Z2 - Z1)*(Z2 - Z1)); 

Console.WriteLine($"Расстояние между двумя точками равно {distance:f2}");
