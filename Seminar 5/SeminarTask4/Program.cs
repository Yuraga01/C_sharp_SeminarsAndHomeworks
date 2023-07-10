/*
айдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
 второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


int [] FillArray (int [] array)
{
Console.Write("Исходный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (-9, 10);
        Console.Write(" " + array [i]);
   
    }
Console.WriteLine ();
return array;
}

void GetIncrease (int [] array)
{
    int [] Inc = null;
    if (array.Length %2 ==0) Inc = new int [array.Length/2];
    else Inc = new int [array.Length/2 + 1];
    Console.WriteLine("Новый массив: ");
    for (int i = 0; i < array.Length/2; i++)
    {
        Inc [i] = array [i] * array [array.Length - 1 - i];
        Console.WriteLine($" {Inc[i]}");
    }
}    
int [] array = new int[9];
FillArray (array);
GetIncrease (array);