// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int GetCountEvenInArray(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}

int[] array = FillArray(100, 999, 10);
PrintArray(array);
Console.WriteLine(GetCountEvenInArray(array));