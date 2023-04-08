// **Задача 39:**Напишите программу,
//  которая перевернёт одномерный массив 
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
void PrintArray(int[] ar)
{
    Console.WriteLine($"[{String.Join(", ", ar)}]");
}

int[] Revers(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
        array[i] = result[i];
    }
    return result;
}

int[] array = FillArray(10, 20, 10);
PrintArray(array);
PrintArray(Revers(array));
PrintArray(array);
