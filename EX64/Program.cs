﻿/* задайте значения N
напишите программу, которая выведет все натуральные числа в промежутке от N до 1
выполнить с помощью рекурсии
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"натуральные числа в промежутке от {n} до 1 = ");

while (n >= 1)
{
    Console.Write(n + " ");
    n--;
}