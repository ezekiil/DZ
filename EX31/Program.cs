/* задайте массив из 12 элементов,
заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива. */

int[] array = new int[12];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-9, 10);
}
Console.WriteLine(string.Join(", ", array));
int sum1 = 0; int sum2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum1 += array[i];
    }
    if (array[i] < 0)
    {
        sum2 -= array[i];
    }
}
Console.WriteLine($"Сумма положительных элементов: {sum1}, сумма отрицательных элементов: {sum2}");
