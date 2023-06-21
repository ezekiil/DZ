/* сформируйте трехмерный массив из неповторяющихся двузначных чисел.
напишите программу, которая будет построчно выводить масиив, добавляя индексы каждого элемента
массив размером 2 х 2 х 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] FillMatrix(int M, int N, int Z)
{
    int[,,] matrix = new int[M, N, Z];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < Z; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


// Console.WriteLine("Введите размер массива: ");
// int M = int.Parse(Console.ReadLine()!);
// int N = int.Parse(Console.ReadLine()!);
// int Z = int.Parse(Console.ReadLine()!);
int[,,] matrix = FillMatrix(2, 2, 2);
PrintMatrix(matrix);
Console.WriteLine();
