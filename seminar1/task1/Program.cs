// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// из условия не понятно какие числа получаем на вход целые или какие-то другие, из примера предположим, что целые
// решим задачу в целых числах, при изменении типа чисел в программу можно внести изменения типа вводных данных

// Решение:

// вводим два числа
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
// добавляем условие для определения максимального числа
if (a > b)
{
    Console.WriteLine($"Максимальное число = {a}");
}
else
{
    Console.WriteLine($"Максимальное число = {b}");
}