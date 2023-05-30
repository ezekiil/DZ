/* задайте двумерный массив.
напишите программу, которая меняет местами указанные строки массива.
*/

int [,] FillMatrix(int rows, int columns) // заполнение двумерного массива
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random(4);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix) // вывод двумерного массива
{
    Console.WriteLine("создан массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{i+1}: ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] ChengeRows(int [,] matrix, int row1, int row2) // замена строк массива
{
    int [,] newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row1-1)
            {
                newMatrix[i,j] = matrix[row2-1,j]; 
            }
            else if (i == row2-1)
            {
                newMatrix[i,j] = matrix[row1-1,j];
            }
            else
            {
                newMatrix[i,j] = matrix[i,j];
            }
        }
    }
    return newMatrix;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int [,] matrix = FillMatrix (rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("введите номер строки для замены: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите номер строки на которую меняем: ");
int row2 = int.Parse(Console.ReadLine()!);
int [,] newMatrix = ChengeRows(matrix, row1, row2);
PrintMatrix(newMatrix);