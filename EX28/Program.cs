/* напишите программу, которая принимает на вход число N
и выдает произведение чисел от 1 до N
4 -> 24
5 -> 120
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

int sum = 1;
for (int i = 1; i <= N; i++)
{
    sum = sum * i;
}
Console.WriteLine($"Произведение чисел от 1 до {N} = {sum}");