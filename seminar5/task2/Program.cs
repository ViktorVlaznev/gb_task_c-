// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// функция суммы элементов массива на нечётных позициях
int SumElemArrOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += i % 2 == 1 ? arr[i] : 0;
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minElem = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxElem = int.Parse(Console.ReadLine());

int[] array = CreateArray(length, minElem, maxElem);

Console.WriteLine($"Сумма элементов массива [{String.Join(", ", array)}] на нечётных позициях = {SumElemArrOddIndex(array)}");