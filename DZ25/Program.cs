/* напишите цикл, который принимает на вход два числа (А и В)
и возводит число А в натуральную степень числа В
3, 5 -> 243 (3^5)
2, 4 -> 16 */

void Pow(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
Pow(a, b);