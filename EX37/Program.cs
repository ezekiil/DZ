/* найдите произведение пар чисел в одномерном массиве.
парой считаем первый и последний элемент, второй и предпоследний и т.д.
результат запишите в новом массиве.
[1, 2, 3, 4, 5] -> 5 8 3
[6, 7, 3, 6] -> 36 21 */

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

void MultiplyArray(int[] array) // нахождение произведения пар чисел 
{
    Console.WriteLine($"произведение пар чисел массива: ");
    int count = array.Length / 2; // число пар элементов в массиве / 2 = колличество пар элементов 
    int[] first = new int[count];
    int[] second = new int[count];
    int index = 0;
    while (index < count)
    {
        first[index] = array[index]; // заполнение массива первых пар элементов
        second[index] = array[array.Length - 1 - index]; // заполнение массива вторых пар элементов
        index++;
    }
    int index1 = 0;
    int index2 = 0;
    while (index1 < count)
    {
        Console.Write($"{first[index1] * second[index2]}, "); // вывод произведения пар элементов
        index1++; 
        index2++;
    }
}

int GetNumberFromUser(string message) // получение числа
{
    Console.Write(message); // вывод сообщения
    if (int.TryParse(Console.ReadLine(), out int result)) // проверка на корректность
    {
        return result; // возврат результата 
    }
    else
    {
        Console.WriteLine("Некорректный ввод числа"); // вывод сообщения
        return GetNumberFromUser(message); // повторный вызов 
    }
}

int num = GetNumberFromUser("Введите колличество элементов массива: ");
int[] array = new int[num]; 
FillArray(array); // заполнение массива
PrintArray(array); // вывод сгенерированного массива
MultiplyArray(array); // вывод произведения пар элементов

