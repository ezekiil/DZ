/* напишите программу, которая будет принимать на вход число
и возвращать сумму его цифр.
Например:
453 -> 12
45 -> 9
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum = sum + number % 10;
    number = number / 10; // берем последнюю цифру (остаток от деления на 10)
}
Console.WriteLine(sum);