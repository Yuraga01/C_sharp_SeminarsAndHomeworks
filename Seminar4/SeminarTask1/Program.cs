void Kol (int n)
{
    int kl;
for (kl = 0; n > 0; kl++)
{
    n=n/10;
   }
Console.WriteLine(kl);
}

Console.WriteLine("Введите ваше число: ");
int N = int.Parse(Console.ReadLine());
Kol(N);

//int kl = 0, a = N;

/*while (a>0)
{
    a=a/10;
    kl++;
}
Console.WriteLine(kl);
*/

