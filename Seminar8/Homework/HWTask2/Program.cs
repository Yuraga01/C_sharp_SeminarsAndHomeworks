/* 
Задайте прямоугольный двумерный массив. Напишите программу, к
оторая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
*/

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

int GetSmallestSum(int[,] array)
{
    int resultRow = 0;
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum = tempSum + array[i, j];

        }
        if (tempSum < min)
        {
            min = tempSum;
            resultRow = i;
        }
    }
    return resultRow;
}

//-------------
Console.WriteLine("Введите количество строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetSmallestSum(array)}");