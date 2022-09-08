// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PointIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны или совпадают");
    else
    {
        double x = (b2 - b1) / (k2 - k1);
        double y = k1 * x + b1;
        Console.WriteLine($"Прямые пересекаются в точке ({x:f2} , {y:f2})");
    }
}

Console.WriteLine("Введите к1: ");
double angCoef1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double freeCoef1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите к2: ");
double angCoef2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double freeCoef2 = double.Parse(Console.ReadLine());

PointIntersection(angCoef1,freeCoef1, angCoef2,freeCoef2);