// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int Power(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}
int a = int.Parse(Prompt("Введите число A: "));
int b = int.Parse(Prompt("Введите степень, в которую надо возвести число A - B: "));
if (b < 0)
{
    Console.WriteLine($"Показатель стемени B должен быть натуральным числом. Вы ввели {b}.");
    return;
}
Console.WriteLine($"{a}^{b}={Power(a, b)}");