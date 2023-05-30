﻿/* задайте двумерный массив размером m x n, заполненный случайными числами
m = 3, n = 4
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() + rnd.Next(-10, 10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2} "); // f2 - для округления дробного числа
        }
        Console.WriteLine();
    }
}

double [,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
