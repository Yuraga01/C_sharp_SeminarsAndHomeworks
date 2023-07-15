/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

int[] EnterNumber(int a)
{
    Console.WriteLine("Введите элементы: ");
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int Counter(int[] array)
{
    int Count = 0;

    int size = array.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) Count++;
        }
    return Count;
}

Console.WriteLine("Введите колличество элементов: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество элементов больше нуля: {Counter(EnterNumber(a))}");
