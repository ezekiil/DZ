﻿// напишите программу которая на вход принимает трехзначное число
// а на выходе показывает последнюю цифру этого числа
// 323 -> 3
// 332 -> 2
// 901 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine()); // приведение строки к числу
int lastDigit = number % 10; // % - остаток от деления 
Console.WriteLine(lastDigit); // вывод последней цифры