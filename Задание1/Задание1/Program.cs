Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine() ?? "");

if(num >= 10000)
{
    int a1 = num / 10000;
    int b1 = num % 10;
 
        if (a1 == b1)
        {
            num = num / 10;
            int a2 = (num / 100) % 10;
            int b2 = num % 10;
                if (a2 == b2)
                Console.WriteLine("Да");
        }
        else 
        Console.WriteLine("Нет");
}
else
Console.WriteLine("Некорректное число!");
