/* пользователь вводит с клавиатуры М чисел
посчитайте, сколько чисел больше 0 ввел пользователь
0, 7, 8, -2, -2 -> 2
1, -7,567, 89, 223 -> 3
*/

int Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return 0;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Array(array);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0: {CountPositiveNumbers(array)}");