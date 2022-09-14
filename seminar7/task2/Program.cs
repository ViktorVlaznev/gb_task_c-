// Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
/// Функция определения наличия числа в двухмерном массиве
/// </summary>
/// <param name="array">данный массив</param>
/// <param name="elem">искомый элемент</param>
void IsElemArray(int[,] array, int elem)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (flag)
        {
            break;
        }
        else
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == elem)
                {
                    flag = true;
                    Console.WriteLine($"Число {elem} находится в массиве в {i + 1} ряду и {j + 1} столбце.");
                    break;
                }
            }
        }
    }
    if (flag == false) Console.WriteLine($"Такого числа в массиве нет.");
}

Console.Write("Введите число рядов массива: ");
int arrRow = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int arrCol = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Введите искомое число: ");
int searchNumber = int.Parse(Console.ReadLine());

Console.WriteLine();
int[,] myArray = GetIntNumArray(arrRow, arrCol, min, max);
PrintArray(myArray);
IsElemArray(myArray, searchNumber);