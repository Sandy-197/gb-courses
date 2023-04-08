// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine() ?? "0");

if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else if (X == 0 && Y != 0)
{
    Console.WriteLine("На оси Y");
}
else if (X != 0 && Y == 0)
{
    Console.WriteLine("На оси X");
}
else
{
    Console.WriteLine("В точке пересечения координат");
}
