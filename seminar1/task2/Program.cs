// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// из условия не понятно какие числа получаем на вход целые или какие-то другие, из примера предположим, что целые
// решим задачу в целых числах, при изменении типа чисел в программу можно внести изменения типа вводных данных

// Решение:

// вводим три числа
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());
// добавляем условие для определения максимального числа
if (a > b && a > c)
{
    Console.WriteLine($"Максимальное число = {a}");
}
else
{
    if (b > c){
    Console.WriteLine($"Максимальное число = {b}");
    } else
    {
    Console.WriteLine($"Максимальное число = {c}");
    }
}