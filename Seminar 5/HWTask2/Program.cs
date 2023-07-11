/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] FillArray (int [] array)
{
Console.Write("массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (-20, 20);
        Console.Write(" " + array [i]);
   
    }
return array;
}

int CountPosNum (int [] array)
{
    int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) result = result + array[i];
}
return result;
}


/*void PrintResult (int Num)
{
    Console.WriteLine();
    Console.WriteLine($"Количество четных элементов в массиве: {Num}");
}*/


//Console.WriteLine("Введите количество элементов массива: ");
//int num = int.Parse(Console.ReadLine());
int [] array = new int [4];
FillArray (array);
Console.WriteLine();
Console.WriteLine($"Сумма: {CountPosNum (array)}");

//PrintResult (CountPosNum (array));