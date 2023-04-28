/* задайте массив вещественных чисел.
найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}

int DifferenceMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
     return max - min;
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным элементами массива = {DifferenceMaxMin(array)}");

