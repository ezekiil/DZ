/* напишите программу, которая принимает на вход число
и выдает количество цифр в числе
456 -> 3
78 -> 2
89126 -> 5
*/

int num = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
int numDigits = GetNumberOfDigits(num);
Console.WriteLine($"Количество цифр в числе = {numDigits}");

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

int GetNumberOfDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}