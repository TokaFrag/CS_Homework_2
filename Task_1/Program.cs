// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int GetNumber()
{
    Console.Write("Enter the number => ");
    int getNumber = Convert.ToInt32(Console.ReadLine());
    return getNumber;
}

int GetCount(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
int searchIndex = 3;
int number = GetNumber();
int count = GetCount(number);

int GetThirdNumber(int number, int count, int index)
{
    int result = (number / Convert.ToInt32(Math.Pow(10, count - index)));
    result = result % 10;
    return result;
}

if (count >= 3)
{
    int thirdNumber = GetThirdNumber(number, count, searchIndex);
    Console.WriteLine(thirdNumber);

}
else
{
    Console.WriteLine("No third number");
}