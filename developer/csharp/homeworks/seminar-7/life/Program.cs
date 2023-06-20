// Доп **
// Игра «Жизнь» была придумана английским математиком Джоном Конвейем в 1970 году.
// Впервые описание этой игры опубликовано в октябрьском выпуске (1970) журнала Scientic American,
// в рубрике «Математические игры» Мартина Гарднера.

// Место действия этой игры – «вселенная» – это размеченная на клетки поверхность.
// Каждая клетка на этой поверхности может находиться в двух состояниях: быть живой или быть мертвой.
// Клетка имеет восемь соседей. Распределение живых клеток в начале игры называется первым поколением.
// Каждое следующее поколение рассчитывается на основе предыдущего по таким правилам:

// 1)пустая(мертвая) клетка с ровно тремя живыми клетками-соседями оживает;
// 2)если у живой клетки есть две или три живые соседки, то эта клетка продолжает жить;
// в противном случае (если соседок меньше двух или больше трех)
// клетка умирает(от «одиночества» или от «перенаселенности»).
// В этой задаче рассматривается игра «Жизнь» на торе.
// Представим себе прямоугольник размером n строк на m столбцов.
// Для того, чтобы превратить его в тор мысленно «склеим» его верхнюю сторону с нижней, а левую с правой.

// Таким образом, у каждой клетки, даже если она раньше находилась на границе прямоугольника,
// теперь есть ровно восемь соседей.

// Ваша задача состоит в том, чтобы найти конфигурацию клеток, которая будет через k поколений от заданного.

// n m k(4 ≤ n, m ≤ 100; 0 ≤ k ≤ 100).

using System;
using static System.Console;
int ROW = 0;
int COLUMN = 1;
Clear();

// 5 5 1
// для проверки тестовых данных, нужно убрать комментарии со строк 39 - 49 и добавить комментарии на строки 110 -113
// ++...
// ..++.
// .+...
// ..+..
// ...+.
// int row = 5;
// int column = 5;
// int k = 1;
// int[,] firstGeneration = new int[row, column];
// firstGeneration[0, 0] = 1;
// firstGeneration[0, 1] = 1;
// firstGeneration[1, 2] = 1;
// firstGeneration[1, 3] = 1;
// firstGeneration[2, 1] = 1;
// firstGeneration[3, 2] = 1;
// firstGeneration[4, 3] = 1;
// .+.++
// +.+..
// .+.+.
// ..+..
// .++..

// 5 5 5
// для проверки тестовых данных, нужно убрать комментарии со строк 63 - 73 и добавить комментарии на строки 110 -113
// ++...
// ..++.
// .+...
// ..+..
// ...+.
// int row = 5;
// int column = 5;
// int k = 5;
// int[,] firstGeneration = new int[row, column];
// firstGeneration[0, 0] = 1;
// firstGeneration[0, 1] = 1;
// firstGeneration[1, 2] = 1;
// firstGeneration[1, 3] = 1;
// firstGeneration[2, 1] = 1;
// firstGeneration[3, 2] = 1;
// firstGeneration[4, 3] = 1;
// .+++.
// .+...
// .+...
// ..++.
// .....

// 4 7 5
// для проверки тестовых данных, нужно убрать комментарии со строк 86 - 103 и добавить комментарии на строки 110 -113
// .+.+.+.
// +.+.+.+
// .+.+.+.
// +.+.+.+
// int row = 4;
// int column = 7;
// int k = 5;
// int[,] firstGeneration = new int[row, column];
// firstGeneration[0, 1] = 1;
// firstGeneration[0, 3] = 1;
// firstGeneration[0, 5] = 1;
// firstGeneration[1, 0] = 1;
// firstGeneration[1, 2] = 1;
// firstGeneration[1, 4] = 1;
// firstGeneration[1, 6] = 1;
// firstGeneration[2, 1] = 1;
// firstGeneration[2, 3] = 1;
// firstGeneration[2, 5] = 1;
// firstGeneration[3, 0] = 1;
// firstGeneration[3, 2] = 1;
// firstGeneration[3, 4] = 1;
// firstGeneration[3, 6] = 1;
// .......
// .......
// .......
// .......

// Если ручные тесты закомментированы, то надо убрать коментарии со строк 110 - 113
int row = int.Parse(Prompt("Введите количество строк: "));
int column = int.Parse(Prompt("Введите количество столбцов: "));
int k = int.Parse(Prompt("Введите поколение: "));
int[,] firstGeneration = GetArray(row, column);

int[,] kGeneration = GetKGenerationOfLife(firstGeneration, k);

WriteLine("Исходное поколение:");
PrintTwoDemensionsArrayChar(ChangeIntToChar(firstGeneration));
WriteLine();

WriteLine($"{k} поколение:");
PrintTwoDemensionsArrayChar(ChangeIntToChar(kGeneration));
WriteLine();

/* --- МЕТОДЫ ------------------------*/
// Запрос строки у пользователя
string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}
// Генерирует массив на row строк и column колонок. Элементы от minValue до maxValue включительно.
int[,] GetArray(int row, int column, int minValue = 0, int maxValue = 0)
{
    int[,] result = new int[row, column];
    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < column; c++)
        {
            result[r, c] = new Random().Next(2);
        }
    }
    return result;
}
// Печатает 2-мерный массив из символьного массива
void PrintTwoDemensionsArrayChar(char[,] inArray)
{
    for (int r = 0; r < inArray.GetLength(ROW); r++)
    {
        for (int c = 0; c < inArray.GetLength(COLUMN); c++)
        {
            Write($"{inArray[r, c]} ");
        }
        WriteLine();
    }
}
// Печатает 2-мерный массив из целочисленного массива
// void PrintTwoDemensionsArray(int[,] inArray)
// {
//     for (int r = 0; r < inArray.GetLength(ROW); r++)
//     {
//         for (int c = 0; c < inArray.GetLength(COLUMN); c++)
//         {
//             Write($"{inArray[r, c]} ");
//         }
//         WriteLine();
//     }
// }
// Изменяет размреность массива для создания мира
int[,] ResizeMassive(int[,] array)
{
    int countCol = array.GetLength(COLUMN) + 2;
    int countRow = array.GetLength(ROW) + 2;
    int[,] result = new int[countRow, countCol];
    for (int r = 1; r < countRow - 1; r++)
    {
        for (int c = 1; c < countCol - 1; c++)
        {
            result[r, c] = array[r - 1, c - 1];
            if (r == 1) result[r - 1, c] = array[countRow - 3, c - 1];
            if (r == countRow - 2) result[r + 1, c] = array[0, c - 1];
        }
        result[r, 0] = array[r - 1, countCol - 3];
        result[r, countCol - 1] = array[r - 1, 0];
    }
    result[0, 0] = array[countRow - 3, countCol - 3];
    result[countRow - 1, countCol - 1] = array[0, 0];
    result[0, countCol - 1] = array[countRow - 3, 0];
    result[countRow - 1, 0] = array[0, countCol - 3];

    return result;
}
// Меняем 2-мерный массив целых на 2-мерный массив символов
char[,] ChangeIntToChar(int[,] array)
{
    char[,] result = new char[array.GetLength(ROW), array.GetLength(COLUMN)];
    for (int r = 0; r < array.GetLength(ROW); r++)
    {
        for (int c = 0; c < array.GetLength(COLUMN); c++)
        {
            result[r, c] = (array[r, c] == 1 ? '*' : '.');
        }
    }
    return result;
}
// Генерирует следующее поколение жизни
int[,] NextGeneration(int[,] array)
{
    int[,] result = new int[array.GetLength(ROW), array.GetLength(COLUMN)];
    int[,] arrayWorld = ResizeMassive(array);
    int count = 0;
    for (int r = 1; r < arrayWorld.GetLength(ROW) - 1; r++)
    {
        for (int c = 1; c < arrayWorld.GetLength(COLUMN) - 1; c++)
        {
            result[r - 1, c - 1] = arrayWorld[r, c];

            count = (arrayWorld[r, c] == 1) ? -1 : 0;
            for (int rw = r - 1; rw < r + 2; rw++)
            {
                for (int cw = c - 1; cw < c + 2; cw++)
                {
                    count += arrayWorld[rw, cw];
                }
            }

            if ((arrayWorld[r, c] == 0) && (count == 3))
            {
                result[r - 1, c - 1] = 1;
            }
            if ((arrayWorld[r, c] == 1) && (count < 2 || count > 3))
            {
                result[r - 1, c - 1] = 0;
            }
        }
    }
    return result;
}
// Возвращает Nое поколение жизни
int[,] GetKGenerationOfLife(int[,] array, int gen)
{
    int[,] result = array;
    for (int n = 0; n < gen; n++)
    {
        result = NextGeneration(result);
    }
    return result;
}