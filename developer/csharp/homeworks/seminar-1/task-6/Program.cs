﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write ("Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
if (value %2 == 0)  // Проверка остатка от деления на 2, если 0, то четное, если не 0(1), то нечётное
{
    Console.WriteLine ("Число "+ value + " чётное.");
}
else 
{
    Console.WriteLine ("Число "+ value + " нечётное.");
}