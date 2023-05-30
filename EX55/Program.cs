/* задайте двумерный массив.
напишите программу, которая заменяет строки на столбцы.
в случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

void FillMatrix(int[,] matrix)
{
    Console.WriteLine("Создан массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
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

int[,] ChengeRows(int[,] matrix)
{
    Console.WriteLine("Массив после замены: ");
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}


Console.WriteLine("Введите количество строк");
if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
{
    Console.WriteLine("Введите количество столбцов");
    if (int.TryParse(Console.ReadLine(), out int columns) && columns > 0)
    {
        int[,] matrix = new int[rows, columns];
        FillMatrix(matrix);
        PrintMatrix(matrix);
        PrintMatrix(ChengeRows(matrix));
    }
    else
    {
        Console.WriteLine("Введены некорректные данные");
    }
}
else
{
    Console.WriteLine("Введены некорректные данные");
}




