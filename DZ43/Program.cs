﻿/* напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
y1 = k1 * x + b1,
y2 = k2 * x + b2,
значения b1, k1, b2 и k2 задаются пользователем
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
    {
    Console.WriteLine($"Прямые параллельны");
    }
    else if (k1 == k2 && b1 == b2)  
    {
    Console.WriteLine($"Прямые совпадают");
    }
    else
    {
    Console.WriteLine($"Прямые не параллельны");
    }
Console.WriteLine();

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($" ({x}; {y})");
}

Intersection(b1, k1, b2, k2);





