﻿/* напишите программу, которая принимает на вход два числа
и проверяет, является ли одно число квадратом другого
5,25 -> да
-4,16 -> да
25,5 -> да
8,9 -> нет
*/

double var1; // первое дробное число, вводит пользователь
while (true) // пока пользователь не введет число, программа завершается с ошибкой
{
    Console.WriteLine("Введите первое число: "); // пользователь вводит первое число 
    if (double.TryParse(Console.ReadLine(), out var1)) // проверяем, что введенное число дробное
    break; // если число дробное, программа завершается
    Console.WriteLine("Ошибка ввода, попробуйте еще раз: "); // если число не дробное, программа завершается с ошибкой
}

double var2;
while (true)
{
    Console.WriteLine("Введите второе число: ");
    if (double.TryParse(Console.ReadLine(), out var2))
    break;
    Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
}

if (var1 * var1 == var2) // проверяем, является ли первое число квадратом второго
{
    Console.WriteLine($"{var1} является квадратом {var2}");
}
else if (var2 * var2 == var1) // проверяем, является ли второе число квадратом первого
{
    Console.WriteLine($"{var2} является квадратом {var1}");
}
else
{
    Console.WriteLine($"числа {var1} и {var2} не являются квадратами друг друга");
}