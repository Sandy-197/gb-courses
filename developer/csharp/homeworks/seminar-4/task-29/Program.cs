// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int min, int max, int size = 0)
{
    if (size == 0) { size = max - min + 1; }
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

void PrintArray(int [] ar)
{
    Console.WriteLine($"[{String.Join(", ", ar)}]");
}
int[] array = FillArray(0, 100, 8);
PrintArray(array);