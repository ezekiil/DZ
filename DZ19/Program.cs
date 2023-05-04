/* напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом (читается одинаково слева направо и справа налево)
14212 -> нет
12821 -> да
23432 -> да */

void Palindrome(int number) // функция проверки 
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10) // проверка на палиндром 
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}

Console.WriteLine("Введите пятизначное число: ");
Palindrome(int.Parse(Console.ReadLine()!));