/* задайте две матрицы.
напишите программу, которая будет находить произведение двух матриц.
наприме, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
результирующая матрица будет:
18 20
15 18
*/

int[,] FillMatrix1(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix1(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

Console.WriteLine("задайте количество строк для 2х матриц: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("задайте количество столбцов для 2х матриц: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("задайте минимальное число: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("задайте максимальное число: ");
int max = int.Parse(Console.ReadLine()!);

int[,] matrix = FillMatrix(rows, columns, min, max);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortMatrix(matrix));
