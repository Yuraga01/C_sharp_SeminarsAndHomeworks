﻿Console.Write("Enter the number: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    if (i%2==0)
        {
            Console.Write(i);
            Console.Write(" ");
        }
}
