// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/// <summary>
/// Функция создания одномерного массива двухзначных неповторяющихся значений
/// </summary>
/// <param name="length">длина массива</param>
/// <returns>одномерный массив</returns>
int[] GetArrayTwoDigitNonrepeating(int length)
{
    int[] array = new int[length];
    int count = 0;
    while (count < length)
    {
        bool flag = true;
        int numberTwo = new Random().Next(10, 100);
        for (int i = 0; i < count; i++)
        {
            if (array[i] == numberTwo)
            {
                flag = false;
            }
        }
        if (flag)
        {
            array[count] = numberTwo;
            count++;
        }
    }
    return array;
}

/// <summary>
/// Функция создания трёхмерного массива из одномерного массива
/// </summary>
/// <param name="array">одномерный массив</param>
/// <param name="length">длина массива</param>
/// <param name="height">высота массива</param>
/// <param name="width">ширина массива</param>
/// <returns>трёхмерный массив</returns>
int[,,] GetIntNumArray(int[] array, int length, int height, int width)
{
    int[,,] result = new int[length, height, width];
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < height; j++)
        {
            for (int k = 0; k < width; k++)
            {
                result[i, j, k] = array[index];
                index++;
            }
        }
    }
    return result;
}

/// <summary>
/// Функция вывода трёхмерного массива в консоль
/// </summary>
/// <param name="array">печатаемый массив</param>
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int xCoordinate = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int yCoordinate = int.Parse(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int zCoordinate = int.Parse(Console.ReadLine());

PrintArray(
    GetIntNumArray(
        GetArrayTwoDigitNonrepeating(xCoordinate * yCoordinate * zCoordinate),
        xCoordinate,
        yCoordinate,
        zCoordinate
    )
);
