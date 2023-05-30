/* задайте значения N
напишите программу, которая выведет все натуральный числа в промежутке от N до 1
выполнить с помощью рекурсии
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int Sum(int n)
{
    if (n == 1) return n;
    if (n > 1) return n + Sum(n - 1);
    return 0;
}

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"сумма натуральных элементов в промежутке от {N} до 1 = {Sum(N)}");