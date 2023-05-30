/* задайте двумерный массив.
найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1,1) и т.д.

1 4 7 2
5 9 2 3
8 4 2 4
-> сумма элементов диагонали = 1+9+2=12
*/

int[,] FillMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
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

void SumDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    Console.WriteLine($"сумма элементов диагонали = {sum}");
}

Console.Write("введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] matrix = FillMatrix(rows, columns, -10, 10);
PrintMatrix(matrix);
SumDiagonal(matrix);