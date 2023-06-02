/* задайте двумерный массив.
напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
в итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] FillMatrix(int rows, int columns, int min, int max) // заполнение двумерного массива
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // вывод двумерного массива
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

int[,] SortMatrix(int[,] matrix) // сортировка двумерного массива
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

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine()!);

int[,] matrix = FillMatrix(rows, columns, min, max);
PrintMatrix(matrix);
Console.WriteLine();
matrix = SortMatrix(matrix);
PrintMatrix(matrix);
