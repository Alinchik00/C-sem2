int GenerateRandomNumber()
{
    return new Random().Next(10, 100);
}

int GetMaxDigit(int randomNumber)
{
    int firstDigit = randomNumber / 10;
    int secondDigit = randomNumber % 10;

    int max = firstDigit;

    if(secondDigit > firstDigit)
    max = secondDigit;
    return max;
}
int randomNumber = GenerateRandomNumber();
int max = GetMaxDigit(randomNumber);
Console.WriteLine("Наибольшая цифра числа: " + max);