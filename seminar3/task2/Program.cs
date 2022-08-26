// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите Х1: ");
double xBegin = double.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
double yBegin = double.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
double zBegin = double.Parse(Console.ReadLine());

Console.Write("Введите Х2: ");
double xEnd = double.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
double yEnd = double.Parse(Console.ReadLine());
Console.Write("Введите Z2: ");
double zEnd = double.Parse(Console.ReadLine());

double distance = Math.Sqrt((xEnd - xBegin) * (xEnd - xBegin) + (yEnd - yBegin) * (yEnd - yBegin) + (zEnd - zBegin) * (zEnd - zBegin));

Console.WriteLine($"Расстояние между точками с координатми ({xBegin},{yBegin},{zBegin}) и ({xEnd},{yEnd},{zEnd}) = {distance:f2}");