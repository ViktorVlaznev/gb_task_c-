// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

void MadeChristmasTree(int num)
{
    for (int i = 1; i <= num; i++)
            {
                Console.Write(new string(' ', num - i));
                Console.Write(new string('*', 2*i - 1));
                Console.WriteLine();
            }
}

Console.Write("Введите высоту ёлочки: ");
int hight = int.Parse(Console.ReadLine());
MadeChristmasTree(hight);