// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

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
/// Функция вычисляет ряд с наименьшей суммой элементов
/// </summary>
/// <param name="array">исходный двухмерный массив</param>
/// <returns>возвращает номер ряда</returns>
/// int GetRowMinSumArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int minSumRow = 1;
    int minSum = 0;
    for (int i = 0; i < column; i++)
    {
        minSum += array[0, i];
    }
    for (int i = 1; i < row; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < column; j++)
        {
            sumRow += array[i, j];
        }
        if (minSum > sumRow)
        {
            minSumRow = i;
            minSum = sumRow;
        }
    }
    return minSumRow;
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
Console.WriteLine($"Минимальная сумма элементов в {GetRowMinSumArray(myArray)} ряду.");
