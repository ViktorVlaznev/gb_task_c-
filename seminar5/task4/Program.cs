// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

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
// функция невозрастающей сортировки массива методом пузырька
int[] SortArrBubbleReverse(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] < arr[j+1])
            {
                int temp = arr[j+1];
                arr[j+1] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minElem = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxElem = int.Parse(Console.ReadLine());

int[] array = CreateArray(length, minElem, maxElem);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] sortArrayReverse = SortArrBubbleReverse(array);
Console.WriteLine($"[{String.Join(", ", array)}]");