/* задайте двумерный массив размером m x n,
заполните его случайными целыми числами
m = 3, n = 4
1 4 8 19
5 -2 33 -2
77 3 8 1
*/


int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
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
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}   

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? ""); // вводим количество строк, знак ? означает, что при вводе пустой строки выведется ошибка
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);