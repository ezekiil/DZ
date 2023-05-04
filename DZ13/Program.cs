/* напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int numDigit = Convert.ToString(N).Length; // находим количество цифр в числе
if (numDigit <= 2) // проверка на трехзначное число
{
Console.WriteLine("третьей цифры нет");
}
else
{
    if (numDigit > 3) // проверка на трехзначное число
        {
        N = N / Convert.ToInt32(Math.Pow(10, numDigit - 3)); // вычисление третьей цифры введённого числа
        }
    N = N % 10;
    Console.WriteLine($"Третья цифра введённого числа: {N}");
}