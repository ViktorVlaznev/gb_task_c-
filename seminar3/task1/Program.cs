// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int numPalindrome = int.Parse(Console.ReadLine());
if (numPalindrome > 9999 && numPalindrome < 100000)
{
    if (numPalindrome % 10 == numPalindrome / 10000 && numPalindrome % 100 / 10 == numPalindrome / 1000 % 10)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
else Console.WriteLine("Введено не пятизначное число!");