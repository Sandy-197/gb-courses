// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayDouble(int min, int max, int size = 0, int digit = 1)
{
    if (size == 0) { size = max - min + 1; }
    double[] result = new double[size];
    int random = 0;
    for (int i = 0; i < size; i++)
    {
        random = new Random().Next(min, max + 1);
        result[i] = Math.Round(new Random().NextDouble() * random, digit);
    }
    return result;
}
void PrintDoubleArray(double[] ar, string separat = ", ")
{
    Console.WriteLine($"[{String.Join(separat, ar)}]");
}

double GetMaxDoubleInArray(double[] arr)
{
    double max = arr[0];
    foreach (double el in arr)
    {
        if (el > max) { max = el; }
    }
    return max;
}

double GetMinDoubleInArray(double[] arr)
{
    var min = arr[0];
    foreach (double el in arr)
    {
        if (el < min) { min = el; }
    }
    return min;
}

double GetDiffMinMax(double[] arr)
{
    return (GetMaxDoubleInArray(arr) - GetMinDoubleInArray(arr));
}
Console.Clear();
double[] array = FillArrayDouble(-100, 100, 10, 4);
PrintDoubleArray(array, "; ");
Console.WriteLine($"Разница между максимальным {GetMaxDoubleInArray(array)} и минимальным {GetMinDoubleInArray(array)} элементами массива равна: {GetDiffMinMax(array):F4}");