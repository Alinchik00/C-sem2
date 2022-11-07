Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
if (multiplicity(number))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
bool multiplicity(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}