/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] Array = new int[8];
for (int i = 0; i < 8; i++)
{
    Array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("[{0}]", string.Join(", ", Array));

    