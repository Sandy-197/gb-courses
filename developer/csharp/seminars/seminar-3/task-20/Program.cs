// Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Clear();
Console.Write("Введите X1: ");
double x1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите X2: ");
double x2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine() ?? "0");

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"d={d:f3}");