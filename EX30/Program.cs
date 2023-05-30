/* напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке
[1, 0, 1, 1, 0, 1, 0, 0] */

int num = GetNumberFromUser("Введите длину массива: ");
int[] array = new int[num];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

int GetNumberFromUser(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

