//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] FillArray (double [] array)
{

Console.Write("массив: ");
Random rand = new Random();
for (int i = 0; i < array.Length; i++) 
{
    array[i] = rand.Next(-10, 10) + rand.NextDouble();
 Console.Write(" " + array [i]);
  }
  return array;
}

double FindMax (double [] array)
{
    double Max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > Max) Max = array [i];
    }
    return Max;
}

double FindMin (double [] array)
{
    double Min = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < Min) Min = array [i];
    }
    return Min;
}

double Decimal (double a, double b)
{
 return Math.Abs(a - b);
}

void PrintResult (double Max, double Min)
{
    Console.WriteLine();
Console.WriteLine($"Макс число: {Max}");
Console.WriteLine($"Мин число: {Min}");
}

Console.WriteLine ("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine());
double [] array = new double [num];
FillArray (array);
PrintResult (FindMax (array), FindMin (array));
Console.WriteLine("Разница: " + Decimal((FindMax(array)), (FindMin(array))));



