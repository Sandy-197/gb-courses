// 1) Реализуйте 3 метода, 
// чтобы в каждом из них получить разные исключения

double? division(double a, double b)
{
    if (b == 0) return null;
    return (a / b);
}

int? PromptDigital(string intro, bool oneline = true)
{
    if (intro != null) Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    try
    {
        int res = int.Parse(Console.ReadLine()!);
        return res;
    }
    catch (System.FormatException error)
    {
        Console.WriteLine(error.Message);
        return null;
    }
}

void MullString(string a, string b)
{
 
    try
    {
        int res = int.Parse(a) * int.Parse(b);
    }
    catch (System.Exception error)
    {
        Console.WriteLine(error.Message);
    }   


}
Console.Clear();
// 1 функция, возвращает nullable тип. т.е. либо результ нужного типа, либо null, 
// если null, значит была ошибка.

double? result = division(10, 0);
if (result != null) Console.Write(result);
else
    Console.WriteLine("Ошибка деления на 0");

// 2 функция, запроса целого числа. обрабатываем, ввод строки вместо числа.
// если ввели не число выходит ошибка, и вовзращается null можно дальше еще раз обработать
int? res = PromptDigital("Введите число: ");

MullString("5","23as4");