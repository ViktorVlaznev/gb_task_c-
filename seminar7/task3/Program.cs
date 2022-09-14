// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/// <summary>
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
/// Функция создания массива из значений среднего арифметического столбцов двумерного массива
/// </summary>
/// <param name="array">исходный двухмерный массив</param>
/// <returns>массив среднеарифметических значений каждого столбца</returns>
double[] GetArithmeticMeanColumn(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        result[i] = sum / array.GetLength(0);
    }
    return result;
}

/// <summary>
/// Функция печати массива в консоль с вещественными числами
/// </summary>
/// <param name="array">исходный массив</param>
void PrintRealArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
    Console.WriteLine();
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
double[] arrArithmeticMean = GetArithmeticMeanColumn(myArray);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintRealArray(arrArithmeticMean);