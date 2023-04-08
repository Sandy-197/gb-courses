// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}
int[] ConvertStringToIntArray(string s, string splitString = " ")
{
    return s.Split(splitString).Select(item => int.Parse(item)).ToArray();
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
int CountMoreZiro(string s)
{
    int[] array = ConvertStringToIntArray(s);
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}

string s = Prompt("Введите любое колво цифр разделенных пробелами:");
PrintArray(ConvertStringToIntArray(s));
Console.WriteLine(CountMoreZiro(s));
