/* напишите программу, которая перевернет одномерный массив
(последний элемент будет на первом месте, а первый на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

void FillArrray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


Console.WriteLine("введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArrray(array);
Console.WriteLine("создан массив: ");
PrintArray(array);

int[] array2 = new int[n];
for (int i = 0; i < n; i++)
{
    array2[i] = array[n - 1 - i];
}
Console.WriteLine("перевернутый массив: ");
PrintArray(array2);
