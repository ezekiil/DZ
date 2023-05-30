/* напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GetMatrix(int m, int n) // создание массива
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    if (m <= 0 || n <= 0) return matrix;
    
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
    Console.WriteLine("Полученный массив ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CheckPosition(int[,] matrix, int i, int j) // проверка позиции
{
    if (i < 0 || j < 0 || i > matrix.GetLength(0) || j > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Элемент на позиции ({i}, {j}) имеет значение {matrix[i-1, j-1]}");
    }
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = GetMatrix(m, n); // создание массива
PrintMatrix(matrix); // вывод массива
Console.WriteLine("Введите позиции элемента: "); // ввод позиции искомого элемента
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
CheckPosition(matrix, i, j); // проверка позиции
