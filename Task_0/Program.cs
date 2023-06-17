// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Random rand = new Random();
int GetRandomNumber = rand.Next(100, 1000);

int GetNumber(int number)
{
    Console.WriteLine(number);
    int getNumber = (number / 10) % 10;
    return getNumber;
}

int result = GetNumber(GetRandomNumber);
Console.WriteLine(result);
