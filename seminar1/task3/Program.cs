﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// вводим число
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
// добавляем условие для определения чётности числа
if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} - чётное!");
} else
{
    Console.WriteLine($"Число {a} - нечётное!"); 
}