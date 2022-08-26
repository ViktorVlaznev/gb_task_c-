// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine());
int count = 1;

while (count <= numN)
{
    Console.Write(count * count * count);
    if (count < numN)
    {
        Console.Write(", ");
    }
    count++;
}

Console.WriteLine();