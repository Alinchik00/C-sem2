int GenerateRandomNumber()
{
    return new Random().Next(100, 1000);
}

int OutSecondDigit(int randomNumber)
{
    Console.WriteLine(randomNumber);
    int firstDigit = randomNumber / 100;
    int secondDigit = (randomNumber - firstDigit*100) / 10;
    int thirdDigit = randomNumber % 10;
    return (firstDigit + thirdDigit);
}

int randomNumber = GenerateRandomNumber();

Console.WriteLine(OutSecondDigit(randomNumber));
