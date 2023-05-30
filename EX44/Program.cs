/* не использую рекурсию, выведите первые N чисел Фибоначчи.
первые два числа Фибоначчи: 0 и 1.
если N = 5 -> 0 1 1 2 3
если N = 3 -> 0 1 1
если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Первые " + N + " чисел Фибоначчи: ");
int[] fib = new int[N];
fib[0] = 0;
fib[1] = 1;
for (int i = 2; i < N; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}
for (int i = 0; i < N; i++)
{
    Console.Write($"{fib[i]} ");
}

