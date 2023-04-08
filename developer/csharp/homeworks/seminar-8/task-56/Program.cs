// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2 = 14
// 5 9 2 3 = 19
// 8 4 2 4 = 18
// 5 2 6 7 = 20
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using static System.Console;
Clear();

int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество столбцов массива: "));
int[,] array = GetArray(m, n, 0, 9);
WriteLine("Начальный массив: ");
PrintArray(array);
WriteLine($"Минимальная сумма в {GetRowWithMinSum(array)} строке.");

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[,] GetArray(int m, int n, int minValue = 0, int maxValue = 0)
{
    int[,] result = new int[m, n];
    if (!(minValue == 0 && maxValue == 0))
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    int i = 1;
    int n = inArray.GetLength(1);
    foreach (var item in inArray)
    {
        Write($"{item,3}" + ((i++ % n == 0) ? "\n" : ""));
    }
}

int GetRowWithMinSum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int result = -1;
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            sum += array[r, c];
        }
        if (sum < minSum || minSum == 0)
        {
            minSum = sum;
            sum = 0;
            result = r;
        }
    }
    return result + 1;
}