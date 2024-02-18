// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] MakeArray(int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(101);
    }
    return array;
}

void PrintArrayAround(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        Console.Write($"{array[i]} ");
        return;
    }
    PrintArrayAround(array, i + 1);
    Console.Write($"{array[i]} ");
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] randomArray = MakeArray(arrayLength);
Console.WriteLine($"Массив: [ {string.Join("; ", randomArray)} ]");
PrintArrayAround(randomArray, 0);