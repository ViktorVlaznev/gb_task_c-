// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// <summary>
/// Функция создания массива случайных целых чисел
/// </summary>
/// <param name="row">кол-во рядов</param>
/// <param name="column">кол-во столбцов</param>
/// <param name="minValue">минимально возможное значение массива</param>
/// <param name="maxValue">максимально возможное значение массива</param>
/// <returns>Возвращает искомый массив</returns>
int[,] GetIntNumArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

/// <summary>
/// Функция вывода двухмерного массива в консоль
/// </summary>
/// <param name="array">печатаемый массив</param>
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/// <summary>
/// Функция сортирует элементы рядов в двумерном массиве в обратном порядке
/// </summary>
/// <param name="arr">исходный массив</param>
/// /// <returns>отсортированный массив</returns>
int[,] SortRowArrReverse(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < column - j - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

Console.Write("Введите число рядов массива: ");
int arrRow = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int arrCol = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] myArray = GetIntNumArray(arrRow, arrCol, min, max);
PrintArray(myArray);
SortRowArrReverse(myArray);
PrintArray(myArray);
