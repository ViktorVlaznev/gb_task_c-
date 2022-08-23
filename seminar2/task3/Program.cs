// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели от 1 до 7: ");
int numberDayWeek = int.Parse(Console.ReadLine());

if (numberDayWeek < 1 || numberDayWeek > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else if (numberDayWeek == 6 || numberDayWeek == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}