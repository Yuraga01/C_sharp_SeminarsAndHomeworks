/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int [] FillArray (int [] array)
{
Console.Write("массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (-9, 10);
        Console.Write(" " + array [i]);
   
    }
return array;
}

/*void IsNumber (int [] array, int usNum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == usNum) Console.Write ("->" + "да");
        else Console.Write (" -> " + "нет");
        }
} */

bool IsNumber (int [] array, int usNum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (usNum == array [i])
            return true;
       
    }
    return false;
}


Console.WriteLine ("Введите число: ");
int usNum = int.Parse (Console.ReadLine ());
int [] array = new int [10];
FillArray (array);

if (IsNumber (array, usNum) == true)Console.Write(" -> да");
else Console.Write(" -> нет");