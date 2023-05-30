/* напишите программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А
4 -> 10 (1+2+3+4=10)
7 -> 28
8 -> 36
*/

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}

int N = GetNumberFromUser("Введите число: ", "Ошибка ввода!");

int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Сумма чисел от 1 до {N} = {sum}");