// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// (k2-k1)/(b1-b2)

int X = 0; // Константы для работы в массиве, X всегда лежит в нулевом элементе
int Y = 1; // Константы для работы в массиве, Y всегда лежит в первом элементе
int K = 0; // Константы для работы в массиве, K всегда лежит в нулевом элементе
int B = 1; // Константы для работы в массиве, B всегда лежит в первом элементе

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

double?[] GetCrossCoordinate(double[] first, double[] second)
{
    double?[] res = new double?[2];
    if (first[K] == second[K])
    {
        res[X] = null;
        res[Y] = (first[B] == second[B]) ? null : 0; // Если res[X] и res[Y] равны null - Прямые совпадают. Иначе паралельны. 
    }
    else
    {
        res[X] = (first[B] - second[B]) / (second[K] - first[K]);
        res[Y] = first[K] * res[X] + first[B];
    }
    return res;
}
// За комментами убрано решение для задачи когда пользователь вводить конкретно коэфициенты
// double?[] GetCrossCoordinate(double k1, double b1, double k2, double b2)
// {
//     double?[] res = new double?[2];
//     if (k1 == k2)
//     {
//         res[X] = null;
//         res[Y] = (b1 == b2) ? null : 0; // Если res[X] и res[Y] равны null - Прямые совпадают. Иначе паралельны. 
//     }
//     else
//     {
//         res[X] = (b1 - b2) / (k2 - k1);
//         res[Y] = k1 * res[X] + b1;
//     }
//     return res;
// }
// double k1 = double.Parse(Prompt("Введите первый коэфициент K1: "));
// double b1 = double.Parse(Prompt("Введите свободный член B1: "));
// double k2 = double.Parse(Prompt("Введите первый коэфициент K2: "));
// double b2 = double.Parse(Prompt("Введите свободный член B2: "));
// double?[] crossCoordinate = GetCrossCoordinate(k1, b1, k2, b2);

// решение с вводом через строку y=kx+b
double[] firstLine = Prompt("Введите первое линейное уравнение вида y=kx+b -> у=")
                    .ToLower()                          // опускаем все в lowcase если вдруг пользоваель ввел большие буквы X
                    .Replace("х", "x")                  // меняем русскую букву х на латинускую x
                    .Split("x")                         // сплитуем в массив через x
                    .Select(item => double.Parse(item)) // переводим из string в double
                    .ToArray();                         // переводим в массив
double[] secondLine = Prompt("Введите второе линейное уравнение вида y=kx+b -> у=")
                    .ToLower()
                    .Replace("х", "x")
                    .Split("x")
                    .Select(item => double.Parse(item))
                    .ToArray();
double?[] crossCoordinate = GetCrossCoordinate(firstLine, secondLine);

if (crossCoordinate[X] != null)
{
    Console.WriteLine($"({crossCoordinate[X]}; {crossCoordinate[Y]})");
}
else
{
    if (crossCoordinate[Y] == null)
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else
    {
        Console.WriteLine("Прямые паралельны.");
    }
}