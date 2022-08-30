// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeOfNumber(int num, int deg)
{
    int res = 1;
    for (int i = 0; i < deg; i++)
    {
        res *= num;
    }
    return res;
}

Console.Write("Введите число А: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int degree = int.Parse(Console.ReadLine());

Console.WriteLine($"{number} в степени {degree} = {DegreeOfNumber(number,degree)}");