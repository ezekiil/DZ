﻿/* напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа
78 -> 8
12 -> 2
85 -> 8
*/

int number = new Random().Next(10, 100); // генерируем случайное число от 10 до 99 
Console.WriteLine(number); // выводим случайное число 
int a1 = number / 10; // получаем первую цифру числа (отбрасываем остаток деления на 10)
int a2 = number % 10; // получаем последнюю цифру числа (берем остаток деления на 10)
int max = a1 > a2 ? a1 : a2; // определяем максимальную цифру ? сравниваем первую с последней 
Console.WriteLine($"Наибольшая цифра числа {number} -> {max}"); // выводим случайное число и максимальную цифру числа 
