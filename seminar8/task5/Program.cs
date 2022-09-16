// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
            if (array[i, j] <= 9)
            {
                Console.Write($"0{array[i, j]}\t");
            }
            else
            {
                Console.Write($"{array[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/// <summary>
/// Функция создания массива 4х4 заполненного по спирали
/// </summary>
/// <returns>искомый массив</returns>
int[,] FillSpirallArray()
{
    int row = 4;
    int column = 4;
    int[,] result = new int[row, column];
    int rowArr = 1;
    int colArr = 1;
    int count = 1;

    for (int k = 0; k < column; k++)
    {
        result[0, k] = count;
        count++;
    }
    for (int k = 0; k < row - 1; k++)
    {
        result[k + 1, column - 1] = count;
        count++;
    }
    for (int k = 0; k < column - 1; k++)
    {
        result[row - 1, column - 2 - k] = count;
        count++;
    }
    for (int k = 0; k < row - 2; k++)
    {
        result[row - 2 - k, 0] = count;
        count++;
    }
    for (int k = 0; k < column - 2; k++)
    {
        result[1, k + 1] = count;
        count++;
    }
    for (int k = 0; k < row - 3; k++)
    {
        result[row - 2 - k, column - 2] = count;
        count++;
    }
    for (int k = 0; k < column - 3; k++)
    {
        result[row - 2, column - 3 - k] = count;
        count++;
    }
    return result;
}

PrintArray(FillSpirallArray());
