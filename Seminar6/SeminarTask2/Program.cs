/* Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

/*Console.WriteLine("Введите число: ");
int dec = int.Parse(Console.ReadLine());
int binary = 0;
if (binary % 2 == 1) binary =1;
int tempDec = dec;
int count=0;
for (int i = 0; dec > 0; i++)
{
    for (int j = 0; tempDec == 0; j++)
    {
        tempDec /=2;
        count ++;
    }
    binary =+ pow(10, count);
    dec -= pow(2, count);
    count=0;
    tempDec = dec;
}
Console.WriteLine(binary);
int pow (int a, int b)
{
    int c=a;
    for (int i = 0; i < b; i++)
    {
        c*=a;
    }
    return c;
} */
Console.WriteLine("Enter num: ");
int dec = int.Parse(Console.ReadLine());
string binary = string.Empty;

while (dec !=0)
{
    int mod = dec%2;
    binary = mod.ToString() + binary;
    dec = dec/2;
}
Console.WriteLine(binary);