/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/



int SumAllDigit (int number)
{
int result = 0;
while (number >0)
{
    result += number %10;
    number = number /10;
}
return result;
}
Console.WriteLine ("Enter number: ");
int number = int.Parse (Console.ReadLine ());
Console.WriteLine(SumAllDigit(number));