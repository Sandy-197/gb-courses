// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}
string DecToAny(int n, int s)
{
    string nums = "01234567890ABCDEF";
    string result = String.Empty;
    while (n > 0)
    {
        result = nums[(n % s)] + result;
        n /= s;
    }
    return result;
}

int a = int.Parse(Prompt("Введите число: "));
int s = int.Parse(Prompt("В какую систему переводим: "));

Console.WriteLine($"{a} - > {DecToAny(a,s)}");