// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
/// Функция перемножения матриц
/// </summary>
/// <param name="array1">первый массив</param>
/// <param name="array2">второй массив</param>
/// <returns>массив произвдения</returns>
int[,] GetProductMatrices(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

Console.Write("Введите число рядов массива1: ");
int arrRow1 = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива1: ");
int arrCol1 = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива1: ");
int min1 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива1: ");
int max1 = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] myArrayFirst = GetIntNumArray(arrRow1, arrCol1, min1, max1);
Console.WriteLine("Первая матрица: ");
PrintArray(myArrayFirst);

Console.Write("Введите число рядов массива2: ");
int arrRow2 = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива2: ");
int arrCol2 = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива2: ");
int min2 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива2: ");
int max2 = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] myArraySecond = GetIntNumArray(arrRow2, arrCol2, min2, max2);
Console.WriteLine("Вторая матрица: ");
PrintArray(myArraySecond);

if (myArrayFirst.GetLength(0) == myArraySecond.GetLength(1))
{
    Console.WriteLine("Произведение матриц: ");
    PrintArray(GetProductMatrices(myArrayFirst, myArraySecond));
}
else
{
    Console.WriteLine("Произведение матриц невозможно.");
}
