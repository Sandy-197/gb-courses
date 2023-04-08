// **Задача 40:**Напишите программу, 
// которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.

bool IsTriangle(int a, int b, int c)
{
    return (a + b > c) && (a + c > b) && (c + b > a);
}
string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int a = int.Parse(Prompt("Введите первую сторону: "));
int b = int.Parse(Prompt("Введите вторую сторону: "));
int c = int.Parse(Prompt("Введите третью сторону: "));
Console.WriteLine(IsTriangle(a, b, c) ? "Да, это треугольник." : "Нет, это не треугольник.");