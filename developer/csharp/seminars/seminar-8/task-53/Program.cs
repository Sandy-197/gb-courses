// **Задача 53:** Задайте двумерный массив. 
//     Напишите программу, которая поменяет местами первую и последнюю строку массива.
//     Например, задан массив:
//     1 4 7 2
//     5 9 2 3
//     8 4 2 4
//     В итоге получается вот такой массив:
//     8 4 2 4
//     5 9 2 3
//     1 4 7 2

const int ROW = 0;
const int COLUMN = 1;

int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество строк массива: "));

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
    for (int i = 0; i < inArray.GetLength(ROW); i++)
    {
        for (int j = 0; j < inArray.GetLength(COLUMN); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}