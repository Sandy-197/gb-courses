//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

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

int[] GetSumPosNeg(int[] array)
{
    int[] result = new int[2];
    result[0] = 0;
    result[1] = 0;
    foreach (int el in array)
    {
        if (el > 0) { result[0] += el; } else { result[1] += el; }
    }
    return result;
}

int[] array = FillArray(-9, 9, 12);
int[] sum = FillArray(0, 0, 2);
Console.WriteLine(string.Join(", ", array));
sum = GetSumPosNeg(array);
Console.WriteLine($"Сумма положительных элементов равна {sum[0]}\nСумма отрицательных элементов равна {sum[1]}");