// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
const int ROW = 0;
const int COLUMN = 1;
const bool BY_COLUMN = true;
const bool BY_ROW = false;

Clear();
int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество столбцов массива: "));

int[,] array = GetArray(m, n, 10, 99);

PrintTwoDemensionsArray(array);
WriteLine();

Write("Средние значения по столбцам: ");
PrintArray(MeanValue(array, BY_COLUMN));
WriteLine();

Write("Средние значения по строкам: ");
PrintArray(MeanValue(array, BY_ROW));

/* Методы */
int[] MeanValue(int[,] array, bool byColumn = true)
{
    int[] res;
    int i = 0;
    
    res = (byColumn) ? new int[array.GetLength(COLUMN)] : new int[array.GetLength(ROW)];
    for (int r = 0; r < array.GetLength(ROW); r++)
    {
        for (int c = 0; c < array.GetLength(COLUMN); c++)
        {
            res[i] += array[r, c];
            if (byColumn) { i++; }
        }
        i = (byColumn) ? 0 : i + 1;
    }
    return res;
}

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[,] GetArray(int row, int column, int minValue = 0, int maxValue = 0)
{
    int[,] result = new int[row, column];
    if (!(minValue == 0 && maxValue == 0))
    {
        for (int r = 0; r < m; r++)
        {
            for (int c = 0; c < n; c++)
            {
                result[r, c] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintTwoDemensionsArray(int[,] inArray)
{
    for (int r = 0; r < inArray.GetLength(ROW); r++)
    {
        for (int c = 0; c < inArray.GetLength(COLUMN); c++)
        {
            Write($"{inArray[r, c]}\t");
        }
        WriteLine();
    }
}

void PrintArray(int[] inArray)
{
    foreach  (int el in inArray)
    {
        Write($"{el} ");
    }
}