// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное
// значение x и возвращает целую часть квадратного корня от введенного числа.
// Нельзя использовать встроенные функции библиотеки Math!

/// <summary>
/// функция нахождения целой части квадратного корня
/// </summary>
/// <param name="number">исходное число</param>
/// <returns>целая часть корня исходного числа</returns>
int Sqrt(int number)
{
    int sqrtInt = number / 2;
    while (sqrtInt > number / sqrtInt)
    {
        sqrtInt--;
    }
    return sqrtInt;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Sqrt(num));
