// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static System.Console;
Clear();

int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество столбцов массива: "));
int[,] array = GetArray(m, n, 0, 9);
WriteLine("Начальный массив: ");
PrintArray(array);
WriteLine("Отсортированный массив: ");
PrintArray(SortTwoDementionsArrayByRow(array, false));

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
// Если direction = true тогда упорядочивается по возрастанию, если false то по убыванию строки.
int[] SortRowArray(int[] array, bool direction = true)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if ((direction) ? array[i] > array[j] : array[i] < array[j])
            {
                int k = array[i];
                array[i] = array[j];
                array[j] = k;
            }
        }
    }
    return array;
}

int[] GetRowArrayFrom2Array(int[,] array, int row)
{
    int[] result = new int[array.GetLength(1)];
    for (int c = 0; c < array.GetLength(1); c++)
    {
        result[c] = array[row, c];
    }
    return result;
}

int[,] PutRowArrayTo2Array(int[,] array, int[] rows, int row)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    result = CopyArray(array);
    // Array.Copy(array, result, array.Length);
    for (int c = 0; c < rows.Length; c++)
    {
        result[row, c] = rows[c];
    }
    return result;
}

int[,] CopyArray(int[,] array)
{
    int[,] res = new int[array.GetLength(0), array.GetLength(1)];
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            res[r, c] = array[r, c];
        }
    }
    return res;
}

int[,] SortTwoDementionsArrayByRow(int[,] array, bool direction = true)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    //Array.Copy(array, result, array.Length);
    result = CopyArray(array);
    for (int r = 0; r < result.GetLength(0); r++)
    {
        result = PutRowArrayTo2Array(result, SortRowArray(GetRowArrayFrom2Array(result, r), direction), r);
    }
    return result;
}