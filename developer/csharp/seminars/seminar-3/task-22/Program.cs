// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// при отрицательно N выводит от N до -1.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

Console.Write("Введтьте число N:");
int n = int.Parse(Console.ReadLine() ?? "0");
int count = 1;

if (n < 0)
{
    count = n;
    n = -1;
}
int maxIndex = Math.Abs(n - count + 1);
int[] a = new int[maxIndex];

for (int i = 0; i < maxIndex; i++)
{
    a[i] = Convert.ToInt32(Math.Pow(count,2));
    count++;
}

for (int i = 0; i < maxIndex; i++)
{
    Console.Write($"{a[i]}" + ((i != maxIndex - 1) ? ", " : ".").ToString());
}

// while (count <= n) 
// {
//     Console.Write($"{Math.Pow(count,2)}"+((count != n) ? ", " : "").ToString());
//     count++;
// }
