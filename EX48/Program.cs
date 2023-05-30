/* задайте двумерный массив размером m x n,
каждый элемент в массиве находится по формуле: Amn = m + n;
выведите полученный массив на экран.
m = 3, n = 4
0 1 2 3
1 2 3 4
2 3 4 5
*/


int[,] FillMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
} 

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? ""); // вводим количество строк, знак ? означает, что при вводе пустой строки выведется ошибка
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] matrix = FillMatrix(rows, columns, -10, 10);
PrintMatrix(matrix);
