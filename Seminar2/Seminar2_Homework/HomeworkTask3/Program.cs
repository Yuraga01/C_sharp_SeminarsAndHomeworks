Console.Write("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Это выходной?");
if (a == 6 || a == 7)
{
    Console.WriteLine("Да");
}
else if (a >= 1 && a <= 5)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Нет такого дня");
}