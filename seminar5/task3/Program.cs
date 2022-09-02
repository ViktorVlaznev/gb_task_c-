// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// функция создания массива по заданной длине и интервале
double[] CreateDoubleArray(int len, double min, double max)
{
    double[] array = new double[len];

    for (int i = 0; i < len; i++)
    {
        Random random = new Random();
        array[i] = random.NextDouble() * (max - min) + min;
    }
    return array;
}
// функция печати массива
void PrintDoubleArray(double[] arr)
{
    Console.Write("[");
    foreach (double elem in arr)
    {
        Console.Write("{0:F2}", elem);
        Console.Write(" ");
    }
    Console.Write("]");
    Console.WriteLine();
}
// функция поиска максимального значения массива
double MaxElemArr(double[] arr)
{
    double max = arr[0];
    foreach (double item in arr)
    {
        max = item > max ? item : max;
    }
    return max;
}
// функция поиска минимального значения массива
double MinElemArr(double[] arr)
{
    double min = arr[0];
    foreach (double item in arr)
    {
        min = item < min ? item : min;
    }
    return min;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minElem = int.Parse(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxElem = int.Parse(Console.ReadLine());

double[] array = CreateDoubleArray(length, minElem, maxElem);
double maximum = MaxElemArr(array);
double minimum = MinElemArr(array);

PrintDoubleArray(array);
Console.Write("Разницу между максимальным и минимальным элементов массива = ");
Console.WriteLine("{0:F2}", maximum - minimum);