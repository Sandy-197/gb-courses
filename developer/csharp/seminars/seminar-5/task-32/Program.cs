//* **Задача 32:**Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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

int[] InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;
    }
    return array;
}

int[] array = FillArray(-9, 9, 12);
int[] revArray = InversArray(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", revArray));