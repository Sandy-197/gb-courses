// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

int n = int.Parse(Prompt("Введите значение N: "));
int m = int.Parse(Prompt("Введите значение M: "));
if (n > m)
{
    int k = m;
    m = n;
    n = k;
}

WriteLine($"Сумма элементов от {n} до {m} = {GetSum(n, m)}");

/* Методы */
int GetSum(int n, int m)
{
    return (n == m) ? n : n + GetSum(n + 1, m);
}

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}
