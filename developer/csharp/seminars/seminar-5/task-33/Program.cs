// **Задача 33:**Задайте массив.Напишите программу,
//   которая определяет, присутствует ли заданное число в массиве.

int[] FillArray(int min, int max, int size = 0)
{
    if (size == 0) { size = max - min + 1; }
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

bool FindElement(int[] array, int elToFind)
{
    foreach (int el in array)
    {
        if (el == elToFind) { return true; }
    }
    return false;
}

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[] array = FillArray(-9, 9, 12);
Console.WriteLine(string.Join(", ", array));
int f = int.Parse(Prompt("Введите значение для проверки: "));
Console.WriteLine($"Число {f} " + (FindElement(array, f) ? "есть" : "нет").ToString() + " в массиве.");