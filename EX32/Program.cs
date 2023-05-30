/* напишите программу замены элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.WriteLine();
}

int GetNumberFromUser(string message)
{
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        return result;
    }
    else
    {
        Console.WriteLine("ошибка ввода, введите число");
        return GetNumberFromUser(message);
    }
}

void Change(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = -collection[index];
        index++;
    }
}

int num = GetNumberFromUser("Введите длину массива: ");
int[] array = new int[num];
FillArray(array);
Console.WriteLine($"сгенерирован случайный массив: ");
PrintArray(array);
Change(array);
Console.WriteLine($"массив после замены: ");
PrintArray(array);
