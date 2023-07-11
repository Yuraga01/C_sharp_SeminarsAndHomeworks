/* Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных 
чисел в массиве.
[345, 897, 568, 234] -> 2 */


int [] FillArray (int [] array)
{
Console.Write("массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (100, 999);
        Console.Write(" " + array [i]);
   
    }
return array;
}

int CountEvNum (int [] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] % 2 == 0) count ++;
}
return count;
}

void PrintResult (int Num)
{
    Console.WriteLine();
    Console.WriteLine($"Количество четных элементов в массиве: {Num}");
}


Console.WriteLine("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine());
int [] array = new int [num];
FillArray (array);
PrintResult (CountEvNum (array));


