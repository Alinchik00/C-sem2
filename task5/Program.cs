Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine()!);

void res(int numA, int numB)
{
    int result = numA % numB;
    if (result == 0)
    {
        Console.WriteLine("Первое число кратно второму");
    }
    else
    {
        Console.WriteLine("Первое число не кратно второму");
        Console.WriteLine("Остаток составляет: " + result);
    }
}

res(numA, numB);