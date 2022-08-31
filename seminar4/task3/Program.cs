// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

// функция создания массива по заданной длине и интервале
int[] CreateArray(int len, int min, int max)
{
    int[] array = new int[len];

    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    
    return array;
}

// функция печати массива
void PrintArray(int[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minElem = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxElem = int.Parse(Console.ReadLine());

PrintArray(CreateArray(length, minElem, maxElem));