/* напишите программу, которая принимает на вход координаты точки (X и Y),
причем X и Y неравны нулю и выдаёт номер четверти плоскости, в которой находится эта точка
(или на какой оси она находится).
Пример:
- x=34; y=-30 -> 4
- x=2; y=4-> 1
- x=-34; y=-30 -> 3
*/

Console.WriteLine("Введите координаты точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0)
{
    Console.WriteLine("Точка находится на оси координат");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в 2 четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}
else
{
    Console.WriteLine("Точка находится на оси координат");
}
Console.WriteLine();
