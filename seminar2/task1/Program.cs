// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = int.Parse(Console.ReadLine());

// добавим проверку на то, что введенное число трёх значное
if (threeDigitNumber > 99 && threeDigitNumber < 1000)
{
    Console.WriteLine($"Вторая цифра числа = {(threeDigitNumber / 10) % 10}");
}
else
{
    Console.WriteLine("Введено не трёхзчначное число.");
}