double? PromptDouble(string intro, bool oneline = true)
{   
    double? res = null;
    if (intro != null) Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    try
    {
        return double.Parse(Console.ReadLine()!);
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Нельзя вводить строку. Повторите ввод!");
    }
    return res;
}

double? result = null;
while (result == null)
    result = PromptDouble("Введите дробное число:");

Console.WriteLine($"Вы ввели: {result}");