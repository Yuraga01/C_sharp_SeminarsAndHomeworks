/*  
Опрелеляем является ли первое введенное 
число квадратом второго введенного числа
*/
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (b * b == a)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
Console.WriteLine("End");
