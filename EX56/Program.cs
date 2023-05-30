/* задайте прямоугольный двумерный массив.
напишите программу, которая будет находить строку с наименьшей суммой элементов.
например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
программа считает сумму элементов в каждой строке
и выдает номер строки с наименьшей суммой элементов: 1я строка
*/

int [,]FillMatrix(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix, int k)
{
    for (int i = 0, minStr = int.MaxValue, sum = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            if (sum < minStr) minStr = sum; k = (i);
        }
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {k+1}");
    return;
}

Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение ");
int max = int.Parse(Console.ReadLine()!);

int[,] matrix = FillMatrix(rows, columns, min, max);
PrintMatrix(matrix);
SortMatrix(matrix, 1);
Console.WriteLine();