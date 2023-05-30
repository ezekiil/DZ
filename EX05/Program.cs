// напишите программу которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? ""); // проверка на пустоту ввода числа и запись в переменную N
int count = 0;
Console.WriteLine($"Все целые числа в промежутке от -{N} до {N}: ");
for (int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
    count = count + 1;
}
Console.WriteLine($"Количество целых чисел: {count}");
