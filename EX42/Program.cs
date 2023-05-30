/* напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number, 2);
Console.WriteLine($"{number} -> {result}");
