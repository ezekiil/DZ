/* напишите программу, которая принимает на вход число
и выдает сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12 */

void Sum(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Sum(a);