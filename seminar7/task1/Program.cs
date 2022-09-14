// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/// <summary>
/// Функция создания массива случайных вещественных чисел
/// </summary>
/// <param name="row">кол-во рядов</param>
/// <param name="column">кол-во столбцов</param>
/// <param name="minValue">минимально возможное значение массива</param>
/// <param name="maxValue">максимально возможное значение массива</param>
/// <returns>Возвращает искомый массив</returns>
double[,] GetRealNumArray(int row, int column, double minValue, double maxValue)
{
    double[,] result = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}

/// <summary>
/// Функция вывода двухмерного массива в консоль
/// </summary>
/// <param name="array">печатаемый массив</param>
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число рядов массива: ");
int arrRow = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int arrCol = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
double min = double.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
double max = double.Parse(Console.ReadLine());

PrintArray(GetRealNumArray(arrRow, arrCol, min, max));