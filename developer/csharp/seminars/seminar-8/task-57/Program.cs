// /* **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3,4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза*\

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int colums = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 9);
PrintArray(array);
WriteLine();
PrintArray(CountUniqueElements(array), title: "Количество элементов по их значениям:\n", div: " => ");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray, string title = "", string div = "\t")
{
    if (title != "") { Write(title); }
    for (int r = 0; r < inArray.GetLength(0); r++)
    {
        Write("[");
        for (int c = 0; c < inArray.GetLength(1); c++)
        {
            Write($"{inArray[r, c]}{((c < inArray.GetLength(1) - 1) ? div : "")}");
        }
        WriteLine("]");
    }
}
void SortArrayByRow(int[,] array)
{
    int[,] k = new int[1, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(0); j++)
        {
            if (array[i, 0] > array[j, 0])
            {
                k[0, 0] = array[i, 0];
                k[0, 1] = array[i, 1];
                array[i, 0] = array[j, 0];
                array[i, 1] = array[j, 1];
                array[j, 0] = k[0, 0];
                array[j, 1] = k[0, 1];
            }
        }
    }
}

bool CheckElement(int[,] array, int fElement, int maxIndex)
{
    for (int i = 0; i < maxIndex; i++)
    {
        if (array[i, 0] == fElement) { return true; }
    }
    return false;
}

int[,] CountUniqueElements(int[,] array)
{
    int[,] result = new int[array.GetLength(0) * array.GetLength(1), 2];
    int index = 0;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            int a = array[k, l];
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == a)
                    {
                        count++;
                    }
                }
            }
            if (!CheckElement(result, a, index))
            {
                result[index, 0] = a;
                result[index, 1] = count;
                index++;
                // Console.WriteLine($"{a} => {count} раз");
            }
        }
    }
    int[,] res = new int[index, 2];
    for (int i = 0; i < index; i++)
    {
        res[i, 0] = result[i, 0];
        res[i, 1] = result[i, 1];
    }
    SortArrayByRow(res);
    return res;
}



