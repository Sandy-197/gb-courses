/* **Задача 63:**Задайте значение N.Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.
N = 5-> "1, 2, 3, 4, 5"
N = 6-> "1, 2, 3, 4, 5, 6"
*/

Console.Clear();
int n = int.Parse(Prompt("Введите количество строк массива: "));
Console.WriteLine(PrintNumbers(n));

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

string PrintNumbers(int n)
{
    if (n==1) return "1";
    string s = PrintNumbers(n-1) + " " + n.ToString();
    return s;
}
