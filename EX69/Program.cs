/* напишите программу, которая на вход принимает два числа A и B
и возводит число A в целую степень B с помощью рекурсии
A = 3; B = 5 -> 243 (3^5)
A = 2; B = 3 -> 8
*/

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return a * Degree(a, b - 1);
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} = {Degree(a, b)}");