/* задайте значения M и N
напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Sum(int m, int n)
{
    if (m == n) return m;
    if (m > n) return m + Sum(m - 1, n);
    if (m < n) return n + Sum(m, n - 1);
    return 0;
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"сумма чисел в промежутке от {M} до {N} = {Sum(M, N)}");