// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int GetSumDigitInInt(int a)
{
    int sum = 0;
    if (a < 0) a *= -1;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}

int a = int.Parse(Prompt("Введите число: "));
Console.WriteLine($"Суммf цифр в числе {a} равно {GetSumDigitInInt(a)}.");