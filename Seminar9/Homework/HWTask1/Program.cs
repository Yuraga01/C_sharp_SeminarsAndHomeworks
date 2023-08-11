/* 
Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
Ваша задача вывести на экран максимальное количество следующих друг за другом 1.
 */

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

int GetNumber(int[] array)
{
    int firstCount = 0;
    int secondCount = 0;
    int max = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == 0)
        {
            if (firstCount > 0 && firstCount < 2) firstCount = 0;
        }
        if (array[i] == 1)
        {
            if (firstCount >= 2) secondCount += 1;
            else firstCount += 1;
        }

        if (firstCount > secondCount) max = firstCount;
        else max = secondCount;
    }
    return max;
}
int length = Prompt("Введите длинну массива");
int[] array = FillArray(length);
PrintArray(array);
Console.WriteLine(GetNumber(array));