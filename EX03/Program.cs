/* напишите программу, которая будет выдавать название дня недели по заданному номеру
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Введите номер дня недели: ");
string userInput1 = Console.ReadLine() ?? ""; // преобразование строки в число
int a = int.Parse(userInput1); 
if ( a == 1 )
{
    Console.WriteLine("понедельник");
}
else if ( a == 2 ) // проверка на равенство чисел
{
    Console.WriteLine("вторник");
}
else if ( a == 3 )
{
    Console.WriteLine("среда");
}
else if ( a == 4 )
{
    Console.WriteLine("четверг");
}
else if ( a == 5 )
{
    Console.WriteLine("пятница");
}
else if ( a == 6 )
{
    Console.WriteLine("суббота");
}
else if ( a == 7 )
{
    Console.WriteLine("воскресенье");
}
else
{
    Console.WriteLine("нет такого дня недели");
}
