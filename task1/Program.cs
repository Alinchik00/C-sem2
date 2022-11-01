int randomNumber = new Random().Next(10, 100);
int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;
Console.WriteLine(randomNumber);
Console.WriteLine(firstDigit);
Console.WriteLine(secondDigit);
if(firstDigit > secondDigit) 
{
    Console.WriteLine(firstDigit);
}
else
Console.WriteLine(secondDigit);