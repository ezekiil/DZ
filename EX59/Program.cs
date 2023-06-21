/*задайте двумерный массив из целых чисел.
напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
наименьший элемент массива: 1
В итоге получается вот такой массив:
9 2 3
4 2 4
2 6 7
*/ 

int a = 0, b = 0;

int[,] FillMatrix(int N)
{
    int[,] matrix = new int[N, N];
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }    
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("случайная матрица: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                a = i; b = j;
            }
        }
    }
    Console.WriteLine("наименьший элемент массива: " + min);
}

void NewMatrix(int[,] matrix)
{
    Console.WriteLine("новая матрица: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != a && j != b)
            {
                Console.Write($"{matrix[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine()!);
int[,] matrix = FillMatrix(N);
PrintMatrix(matrix);
SortMatrix(matrix);
NewMatrix(matrix);
