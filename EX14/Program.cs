﻿/* напииште программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0) // проверка кратности 7 и 23 в одновременном случае
{
    Console.WriteLine($"введенное число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"введенное число {number} не кратно 7 и 23");
}