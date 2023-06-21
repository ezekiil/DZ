/* задайте значения M и N
напишите программу, которая выведет все натуральные числа в промежутке от M до N
M = 1; N = 5 -> от 1 до 5
M = 4; N = 8 -> от 4 до 8
*/

Console.Write("введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = M;
if (M < N)
{
    while (i <= N)
    {
    Console.Write(i + " "); i++;
    }
}
else
{
    while (i >= N)
    {
    Console.Write(i + " "); i--;
    }
}