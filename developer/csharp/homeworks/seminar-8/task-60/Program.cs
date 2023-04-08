// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
const int ROW = 0;
const int COLUMN = 1;

Clear();

int m = int.Parse(Prompt("Введите первую размерность массива m: "));
int n = int.Parse(Prompt("Введите первую размерность массива n: "));
int z = int.Parse(Prompt("Введите первую размерность массива z: "));

int[,,] array = GetArray(m, n, z, 1, 9);

WriteLine("Массив: ");
PrintArray(array);


string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[,,] GetArray(int m, int n, int z, int minValue = 0, int maxValue = 0)
{
    int[,,] result = new int[m, n, z];
    if (!(minValue == 0 && maxValue == 0))
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    result[i, j, k] = new Random().Next(minValue, maxValue + 1);
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    int m = inArray.GetLength(0);
    int n = inArray.GetLength(1);
    int z = inArray.GetLength(2);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                WriteLine($"{inArray[i, j, k]}({i},{j},{k})");
            }
        }
    }
}