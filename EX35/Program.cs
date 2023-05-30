/* задайте одномерный массив из 123 случайных чисел.
найдите количество элементов массива, значения которых лежат в отрезке [10,99]
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int[] array = GetRandomArray(123);
PrintArray(array);
int count = FindElementsInIntr(array);
Console.WriteLine($"В данном массиве {count} элементов лежат в пределе 10-99");

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 124);
    }
    return array;
}

void PrintArray(int[] array)
{

    Console.WriteLine(string.Join(" ", array));
}

int FindElementsInIntr(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el >= 10 && el <= 99)
            count++;
    }
    return count;
}