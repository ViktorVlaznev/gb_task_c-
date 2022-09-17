// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/// <summary>
/// Рекурсивная функция нахожения суммы в заданном интервале
/// </summary>
/// <param name="startNum">начальное число интервала</param>
/// <param name="endNum">конечное число интервала</param>
/// <returns>сумму чисел в заданном интервале</returns>
int GetSumInterval(int startNum, int endNum)
{
    if (startNum > endNum)
    {
        int temp = startNum;
        startNum = endNum;
        endNum = temp;
    }
    if (startNum == endNum)
    {
        return startNum;
    }
    else
    {
        return endNum + GetSumInterval(startNum, --endNum);
    }
}

Console.Write("Введите начальное число: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите конечное число: ");
int end = int.Parse(Console.ReadLine());

if (start > 0 && end > 0)
{
    Console.WriteLine($"Сумма чисел в интервале = {GetSumInterval(start, end)}");
}
else
    Console.WriteLine("Введены не натуральные числа");
