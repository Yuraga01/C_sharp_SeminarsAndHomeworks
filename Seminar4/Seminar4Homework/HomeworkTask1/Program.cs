/*
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exp (int a, int b) 
{
    int temp = a;
    for (int i = 1; i < b; i++)
    {
        temp = temp * a;
    }
    return temp;
}

Console.WriteLine("Enter first num: ");
int usNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second num: ");
int usNum2 = int.Parse(Console.ReadLine());

Console.WriteLine(Exp(usNum1, usNum2));
