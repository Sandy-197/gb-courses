// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
int Prompt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

string PrintNumbers(int min, int max)
{
    if (max == min)
    {
        return min.ToString();
    }
    return PrintNumbers(min, max - 1) + " " + max.ToString();
}

int min = Prompt("Введите меньшее число диапазона: ");
int max = Prompt("Введите максимальное число диапазона: ");
Console.Write (PrintNumbers (min,max));