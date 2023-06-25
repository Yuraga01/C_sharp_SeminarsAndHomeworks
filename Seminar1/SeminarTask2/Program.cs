Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
    default:
    Console.WriteLine("Нет такого дня");
    break;
}








/* if ((day >=1) &&  (day <= 7))
{
    if (day == 1)
{
Console.WriteLine("Понедельник");
}    
if (day == 2)
{
Console.WriteLine("Вторник");
}   
if (day == 3)
{
Console.WriteLine("Среда");
}   
if (day == 4)
{
Console.WriteLine("Четверг");
}   
if (day == 5)
{
Console.WriteLine("Пятница");
}   
if (day == 6)
{
Console.WriteLine("Суббота");
}   
if (day == 7)
{
Console.WriteLine("Воскресенье");
}   
}
else
{
Console.WriteLine("Такого дня недели не существует");
}
*/
// можно было испольщовать switch case