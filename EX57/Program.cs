/* составить частотный словарь элементов двумерного массива.
частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

набор данных {1, 9, 9, 0, 2, 8, 0, 9}
частотный массив:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

Console.Write("введите длину массива: ");
int N = int.Parse(Console.ReadLine()!);
int[] arr = new int[N];
Random rnd = new Random();
for (int i = 0; i < N; i++)
{
    arr[i] = rnd.Next(0, 10);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] SortArray(int[] arr)
{
    Console.WriteLine("частотный словарь элементов двумерного массива: ");
var mass = arr.GroupBy(x => x); //группируем массив используя в качестве ключа само число из массива
 foreach (IGrouping<int, int> group in mass) // проходим по группам и считаем количество элементов
 Console.WriteLine($"Число {group.Key} встречается {group.Count()} раз");
return arr;
}

PrintArray(arr);
Console.WriteLine();
SortArray(arr);


