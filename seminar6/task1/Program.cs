// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountPositivNum(int quantity)
{
    int count = 0;
    for (int i = 0; i < quantity; i++)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine($"Кол-во положительных чисел: {count}");
}
Console.Write("Введите кол-во чисел: ");
int quant = int.Parse(Console.ReadLine());
CountPositivNum(quant);