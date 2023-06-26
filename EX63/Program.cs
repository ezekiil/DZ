/* задайте значение N.
напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
N = 5 -> 1, 2, 3, 4, 5
N = 6 -> 1, 2, 3, 4, 5, 6
*/

Console.Write("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.Write(i + " "); i++;
}
