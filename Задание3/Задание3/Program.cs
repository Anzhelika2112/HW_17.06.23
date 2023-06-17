Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ??"");

int count = 1;

while (count <= num)
{
    int Pow = count*count*count;
    Console.Write ($"{Pow}, ");

count = count+1;
}