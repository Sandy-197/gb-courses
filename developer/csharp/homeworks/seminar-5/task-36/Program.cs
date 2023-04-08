// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumOddElementsInArray(int[] arr)
{
    int sum = 0;
    for (int i = 1;i<arr.Length;i+=2)
    {
        sum+=arr[i];
    }
    return sum;
}

int[] array = FillArray(-10, 10, 10);
PrintArray(array);
Console.WriteLine(GetSumOddElementsInArray(array));