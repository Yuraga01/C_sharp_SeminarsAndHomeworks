/* Напишите программу, которая принимает на вход число N, а выдает произведение числе от 1 до N
4 --> 24
5 --> 120 */

int multiply (int numUs)
{
    int temp = 1;
    for (int i = 1; i <= numUs; i++)
    {
temp = temp *i;
    }
return temp;
}
Console.Write("Enter the number: ");
int numUs = int.Parse(Console.ReadLine());
int result = (multiply(numUs));
Console.WriteLine(result);