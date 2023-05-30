/* задайте массив заполненный случайными положительными трехзначными числами.
напишите программу, которая покажет количество четных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(CountEvenNumbers(array));