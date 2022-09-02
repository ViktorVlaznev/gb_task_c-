// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// функция создания массива по заданной длине и интервале
int[] CreateArray(int len, int min, int max)
{
    int[] array = new int[len];

    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    
    return array;
}
// функция подсчёта чётных чисел в массиве
int EvenNumbersArray(int[] arr)
{
    int count = 0;

    foreach (int elem in arr)
    {
        count += (elem % 2 == 0) ? 1 : 0; 
    }
    
    return count;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());

int[] arrayThreeDigit = CreateArray(length, 100, 999);

Console.WriteLine($"Число чётных чисел в массиве [{String.Join(", ", arrayThreeDigit)}] = {EvenNumbersArray(arrayThreeDigit)}");