/* задайте массив
напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да */

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    Console.WriteLine($"сгенерирован случайный массив: ");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
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

void Find(int[] array, int number) // нахождение заданного числа
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        if (array[index] == number)
        {
            Console.WriteLine("Число найдено");
            return;
        }
        index++;
    }
    Console.WriteLine("Число не найдено");
    return;
}

int num = GetNumberFromUser("Введите длину массива: ");
int[] array = new int[num];
FillArray(array);
PrintArray(array);
int number = GetNumberFromUser("Введите искомое число: ");
Find(array, number);
