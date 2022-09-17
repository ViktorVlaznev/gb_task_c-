// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

/// <summary>
/// Метод вычисления функции Аккермана
/// </summary>
/// <param name="m">переменная 1</param>
/// <param name="n">переменная 2</param>
/// <returns>значение функции Аккермана</returns>
int CalcFuncAkkermana(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return CalcFuncAkkermana(m - 1, 1);
    else
        return CalcFuncAkkermana(m - 1, CalcFuncAkkermana(m, n - 1));
}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(CalcFuncAkkermana(num1, num2));
