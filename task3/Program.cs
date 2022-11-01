int randomNumber = new Random().Next(100, 1000);
Console.WriteLine(randomNumber);
int firstDigit = randomNumber / 100;
int secondDigit = randomNumber % 100 / 10;
int thirdDigit = randomNumber % 100 % 10;
Console.WriteLine(firstDigit);
Console.WriteLine(secondDigit);
Console.WriteLine(thirdDigit);
int newNumber = firstDigit*10 + thirdDigit;

Console.WriteLine("Новое число: " + newNumber);