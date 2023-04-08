// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int Pow (int a, int b)
{
    return (b == 0) ? 1 : a * Pow (a, b-1);
}

int num = Prompt("Введите основание степени: ");
int pow = Prompt("Введите степень: ");
Console.Write (Pow (num,pow));