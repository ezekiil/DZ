/* напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник со сторонами такой длины.
*теорема о неравенстве треугольника: каждая сторона треугольнка меньше суммы двух других
*/

Console.WriteLine("введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && b + c > a && c + a > b)
{
    Console.WriteLine("такой треугольник может быть");
}
else
{
    Console.WriteLine("такой треугольник не может быть");
}
