// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using System;
using static System.Console;

Clear();
int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество строк массива: "));

int[,] array = GetArray(m, n);
PrintArray(array);
int sumDiag =GetSumDiag(array);
WriteLine($"Сумма диагнальных элементов равна: {sumDiag}");

/* Методы */
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
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int GetSumDiag(int[,] array)
{
    int res = 0;
    int max = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);

    for (int i = 0; i < max; i++)
    {
        res += array[i, i];
    }
    return res;
}
