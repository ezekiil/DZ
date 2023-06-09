﻿/* вывести первые N строк треугольника Паскаля.
сделать вывод в виде равнобедренного треугольника
 */

 Console.Write("Введите количество строк треугольника: ");
 int n = Convert.ToInt32(Console.ReadLine());

for (int y = 1; y <= n; y++) // вершина треугольника
{
    int c = 1; // начальное значение
    for (int q = 1; q <= n-y; q++) // пробелы между цифрами
    {
        Console.Write(" ");
    }
    for (int x = 1; x <= y; x++) // пробелы между столбцами
    {
        Console.Write(" {0:D}", c); // пробелы в начале строки 
        c = c * (y - x) / (x); // расчет следующих строк треугольника
    }
    Console.WriteLine();
}