// Задача 13: Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int thirdDigitNumber = int.Parse(Console.ReadLine());
int thirdDigit = thirdDigitNumber / 100 % 10;
if (thirdDigit == 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(thirdDigit);
}