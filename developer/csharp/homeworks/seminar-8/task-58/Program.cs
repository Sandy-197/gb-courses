// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
const int ROW = 0;
const int COLUMN = 1;

Clear();

int m1 = int.Parse(Prompt("Введите количество строк первой матрицы: "));
int n1 = int.Parse(Prompt("Введите количество столбцов первой матрицы: "));
int m2 = int.Parse(Prompt("Введите количество строк второй матрицы: "));
int n2 = int.Parse(Prompt("Введите количество столбцов второй матрицы: "));

int[,] arrayFirst = GetArray(m1, n1, 1, 9);
int[,] arraySecond = GetArray(m2, n2, 1, 9);

WriteLine("Первый массив: ");
PrintArray(arrayFirst);
WriteLine("Второй массив: ");
PrintArray(arraySecond);

int[,] arrayMulty = GetMulOfTwoMatrix(arrayFirst, arraySecond);
if (arrayMulty.Length!=0) 
{
    WriteLine("Произведение матриц: ");
    PrintArray(arrayMulty);
}
else
{
    WriteLine($"Произведение матриц невозможно. Кол-во колонок первой матрицы {n1}. Должно быть равно кол-ву строк второй матрицы {m2}.");
}

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
    int n = inArray.GetLength(COLUMN);
    foreach (var item in inArray)
    {
        Write($"{item,5}" + ((i++ % n == 0) ? "\n" : ""));
    }
}

int[,] GetMulOfTwoMatrix(int[,] arrayFirst, int[,] arraySecond)
{
    if (arrayFirst.GetLength(COLUMN) != arraySecond.GetLength(ROW)) return new int[0, 0];

    int resultRow = arrayFirst.GetLength(ROW);
    int resultColumn = arraySecond.GetLength(COLUMN);
    int columns = arrayFirst.GetLength(COLUMN);

    int[,] result = new int[resultRow, resultColumn];
    for (int i = 0; i < resultRow; i++)
    {
        for (int j = 0; j < resultColumn; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                result[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
    return result;
}