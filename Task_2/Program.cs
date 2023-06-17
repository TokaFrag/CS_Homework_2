// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter the number of the day of the week => ");
int numberDay = Convert.ToInt32(Console.ReadLine());

switch (numberDay)
{
    case 1:
        Console.WriteLine("Monday. It's not a day off.");
        break;
    case 2:
        Console.WriteLine("Tuesday. It's not a day off.");
        break;
    case 3:
        Console.WriteLine("Wednesday. It's not a day off.");
        break;
    case 4:
        Console.WriteLine("Thursday. It's not a day off.");
        break;
    case 5:
        Console.WriteLine("Friday. It's not a day off.");
        break;
    case 6:
        Console.WriteLine("Saturday. Today is a day off.");
        break;
    case 7:
        Console.WriteLine("Sunday. Today is a day off.");
        break;
    default:
        Console.WriteLine("There is no such day of the week.");
        break;
}