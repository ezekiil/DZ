/* задайте две матрицы.
напишите программу, которая будет находить произведение двух матриц.
наприме, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
результирующая матрица будет:
18 20
15 18
*/

int[,] FillMatrix1(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

int[,] FillMatrix2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix;
}

int[,] matrix1 = FillMatrix1(new int[2, 2]);
int[,] matrix2 = FillMatrix2(new int[2, 2]);
PrintMatrix(matrix1);
Console.WriteLine(" ");
PrintMatrix(matrix2);
Console.WriteLine(" ");
PrintMatrix(MultiplyMatrix(matrix1, matrix2));