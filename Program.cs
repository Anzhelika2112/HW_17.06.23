/* Console.Clear();
int X = 0, Y = 0;

InitCoordinatesByUser(ref X, ref Y); // Вызов метода с передачей параметров по ссылке (ref)
PrintQuarterByCoords(X, Y); // Вызов метода с передачей параметров по значению 

static void InitCoordinatesByUser(ref int X, ref int Y)
{
    try
    {
        Console.Write("Введите X: ");
        X = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Y: ");
        Y = int.Parse(Console.ReadLine()?? "");
    }
    catch(Exception exc)
    {
        Console.Write($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void PrintQuarterByCoords(int X, int Y)
{
    if(X > 0 && Y > 0)
        Console.WriteLine("1");
    else if(X < 0 && Y > 0)
        Console.WriteLine("2");
    else if(X < 0 && Y < 0)
        Console.WriteLine("3");
    else if(X > 0 && Y < 0)
        Console.WriteLine("4");
    else
        Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
*/

/* Console.Clear();
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());


if (num == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (num == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (num == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (num == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else 
    Console.WriteLine("Ошибка! Введите номер четверти.");
    */

/*
Console.Clear();
Console.Write("Введите X1: ");
double X1 = double.Parse(Console.ReadLine());

Console.Write("Введите X2: ");
double X2 = double.Parse(Console.ReadLine());

Console.Write("Введите Y1: ");
double Y1 = double.Parse(Console.ReadLine());

Console.Write("Введите Y2: ");
double Y2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1)); 
Console.WriteLine($"Расстояние между двумя точками равно {distance:f2}");
*/

/* Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 1;

while (count <= num)
{
    int Pow = count*count;
    Console.Write ($"{Pow}, ");

count = count+1;
}
*/