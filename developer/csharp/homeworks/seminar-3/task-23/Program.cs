// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * при N < 0, нужно вывести от N до -1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine()??"";
    return res;
}

Console.Clear();
int n = int.Parse(Prompt("Введтьте число N:") ?? "0");
int count = 1;
if (n < 0)
{
    count = n;
    n = -1;
}

int tempCount = count; // сохраняем count для следующего решения

// решение через массив
// мое решение, мне кажется проще чем у вас в 22 задаче на семинаре. 
// по крайней мере нет в цикле создания массива и недопониманий почему индекс массива переменная вне цикла :)

Console.WriteLine("Решение через массив");
int maxIndex = Math.Abs(n - count + 1);
int[] a = new int[maxIndex];

for (int i = 0; i < maxIndex; i++)
{
    a[i] = Convert.ToInt32(Math.Pow(count,3));
    count++;
}

for (int i = 0; i < maxIndex; i++)
{
    Console.Write($"{a[i]}" + ((i != maxIndex - 1) ? ", " : ".\n").ToString());
}
Console.WriteLine($"{String.Join(", ",a)}.");

// решение через while, мне кажется в данном случае оно проще и понятнее чем через for, если речь только о выводе на экран.
count = tempCount; //востанавливаем значения count для следующего решения.

Console.WriteLine("\nРешение через while, мне кажется проще");
while (count <= n) 
{
    Console.Write($"{Math.Pow(count,3)}"+((count != n) ? ", " : ".").ToString());
    count++;
}
