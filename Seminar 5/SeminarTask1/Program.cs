/*Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */



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

void ChangeNum (int [] array)
{
    Console.Write("Новый массив: ");
    for (int i = 0; i < array.Length; i++)
{
    array [i] *= -1;
    Console.Write (" " + array [i]);
}
}

int [] array = new int [4];
FillArray (array);
ChangeNum (array);

