/***Задача 35:**Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5*/

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
int GetCountElements(int[] array, int min, int max)
{
    int result = 0;
    foreach (var el in array)
    {
        result+=(el >= min && el <=max) ? 1 : 0;   
    }
    return result;
}

int[] array = FillArray(0, 1000, 123);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"{GetCountElements(array,10,99)}");