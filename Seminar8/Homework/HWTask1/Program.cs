/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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


int[,] FindPlaceElInString(int[,] array, int i)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int j = k + 1; j < array.GetLength(1); j++)
        {
            if (array[i, k] < array[i, j])
            {
                int temp = array[i, k];
                array[i, k] = array[i, j];
                array[i, j] = temp;
            }
        }
    }
    return array;
}
int[,] SortArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        resultArray = FindPlaceElInString(array, i);
    }
    return resultArray;
}
Console.WriteLine("Введите количество строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количестов столбцов массива");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine("Отсортированный массив");
PrintArray(SortArray(array));