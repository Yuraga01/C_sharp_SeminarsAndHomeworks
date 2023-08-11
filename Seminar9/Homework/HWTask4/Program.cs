/* 
Даны два положительных целых числа, представленных в виде строк. 
Необходимо получить сумму чисел, которые представлены этими строками. 
Причем полученная сумма должна быть преобразована в строку. 
*/


int ToInt(string text)
{
    int result = 0;
    for (int i = 0; i < text.Length; i++)
    {
        result += ((int)text[text.Length - i - 1] - 48) * (int)Math.Pow(10, i);
    }

    return result;
}

Console.WriteLine("Enter first number");
string a= Console.ReadLine();
Console.WriteLine("Тип переменной: " + a.GetType());
Console.WriteLine("Enter first number");
string b= Console.ReadLine();
Console.WriteLine("Тип переменной: " + b.GetType());
int c = ToInt(a);
int d = ToInt(b);
Console.Write("Сумма переменных: ");
Console.Write(c+d);