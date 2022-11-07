Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine()!);

if (numA == numB * numB || numB == numA * numA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}