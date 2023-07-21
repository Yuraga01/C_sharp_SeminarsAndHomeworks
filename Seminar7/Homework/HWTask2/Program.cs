/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 100);
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

void GetNumber(int[,] array, int row, int column)
{
    if (row > (array.GetLength(0) -1) || column > (array.GetLength(1)-1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else Console.WriteLine(array[row, column]);

}
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
int[,] array = CreateArray(rows, columns);
PrintArray(array);
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
GetNumber(array, row, column);