/* напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому.
если число 2 не кратно числу 1, то программа выводит остаток от деления 
второго числа на первое.
34,5 -> не кратно, остаток 4
16,4 -> кратно
*/

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 % number1 == 0) // если число 2 кратно числу 1
{
    int result1 = number2 / number1; // возвращает целую часть числа (кратное)
    Console.WriteLine($"{number2} кратно {number1} в {result1} раз");
}
else
{
    int result2 = number2 % number1; // возвращает остаток от деления чисел
    Console.WriteLine($"{number2} не кратно {number1}, остаток {result2}");
}