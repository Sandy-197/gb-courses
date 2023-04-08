// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

int CountDigitInInt(int n) // подсчет кол-ва разрядов в числе, через математику. Так же можно через длину строки. но не так интересно.
{
    int count = 0;
    while (n != 0)
    {
        count++;
        n /= 10;
    }
    return count;
}
bool IsPalindrom(int p) // Решение через математику
{
    int t = p;
    int revp = 0;
    while (t > 0)
    {
        revp = revp*10 + t % 10;
        t /= 10;
    }
    return (revp-p==0);
}
bool IsPolindrom(int p) // Еще одно решение через математику и логику.
{
    int i = 0;
    int countDigit = CountDigitInInt(p);
    int coutnDigitHulf = countDigit / 2;
    while (i < coutnDigitHulf)
    {
        if (Convert.ToInt32(p / Math.Pow(10, i)) % 10 != Convert.ToInt32(p / Math.Pow(10, countDigit - i - 1)) % 10) { return false; }
        i++;
    }
    return true;
}

bool IsPolindrom2(int p)  // Решение через конвертацию и разворачивание строки
{
    return ((Convert.ToInt32(string.Concat(p.ToString().Reverse().ToArray())) - p) == 0);
}

int n = Prompt("Введите число: ");
// if (n < 10000 || n > 99999) { Console.WriteLine("Вы ввели не 5 значное число."); return ; } // нужно только если хотим обрабатывать 5 значные
Console.WriteLine($"Число {n} " + (IsPalindrom(n) ? "" : "не ").ToString() + "палиндром.");
Console.WriteLine($"Число {n} " + (IsPolindrom(n) ? "" : "не ").ToString() + "палиндром.");
Console.WriteLine($"Число {n} " + (IsPolindrom2(n) ? "" : "не ").ToString() + "палиндром.");
