// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// вводим число
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int count = 1;                  // введем переменную счётчика
// добавим цикл доля нахождения и вывода четных чисел
while (count <= a)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}