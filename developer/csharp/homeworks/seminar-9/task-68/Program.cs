// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

int m = int.Parse(Prompt("Введите значение m: "));
int n = int.Parse(Prompt("Введите значение n: "));

if (n > 0 && m > 0)
{
    WriteLine($"Вычисление функции Аккермана для А({m}, {n}) = {GetAccerman(m, n)}");
}
else
{
    WriteLine($"Вычисление невозможно, m и n должны быть больше нуля.");
}

/* Методы */
int GetAccerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return GetAccerman(m - 1, 1);
    }
    else
    {
        return GetAccerman(m - 1, GetAccerman(m, n - 1));
    }
}

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}