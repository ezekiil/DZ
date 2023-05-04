/* задайте двумерный массив из целых чисел
найдите среднее арифметическое элементов в каждом столбце.
например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GetMatrix(int m, int n) // создание массива
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // вывод массива
{
    Console.WriteLine("Получен массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SredArifm(int[,] matrix) // среднее арифметическое столбца массива
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"среднее арифметическое {j+1} столбца: {sum / matrix.GetLength(0):f2}");
    }
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = GetMatrix(m, n); // создание массива
PrintMatrix(matrix); // вывод массива
SredArifm(matrix);
