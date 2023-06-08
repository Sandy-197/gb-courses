// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, 
// и возвращающий новый массив, 
// каждый элемент которого равен разности элементов двух входящих массивов 
// в той же ячейке. 
// Если длины массивов не равны, необходимо как-то оповестить пользователя.

// Вариант 1. простая проверка длинн массивов. 
// если они разные то возвращаем null и обрабатываем его в основной программе
int[]? DiffElements(int[] array_a, int[] array_b)
{
    if (array_a == null || array_b == null || array_a.Length != array_b.Length) return null;
    int[]? result = new int[array_a.Length];
    for (int i = 0; i < array_a.Length; i++)
    {
        result[i] = array_a[i] - array_b[i];
    }
    return result;
}

// Вариант когда все нормально
// int[] array_a = {1, 2, 3, 4, 5, 6, 7};
// int[] array_b = {7, 6, 5, 4, 3, 2, 1};

// Вараинт, когда длина разная, меньше первый
// int[] array_a = {1, 2, 3, 4, 6, 7};
// int[] array_b = {7, 6, 5, 4, 3, 2, 1};

// // Вараинт, когда длина разная, меньше второй
// int[] array_a = {1, 2, 3, 4, 6, 7, 8};
// int[] array_b = {7, 6, 5, 4, 3, 2};

// Вараинт, когда один null. Ну тут сам dotnet не дает сильно с null играть :) надо спец тип объявлять
int[] array_a = null; //{1, 2, 3, 4, 6, 7, 8};
int[] array_b = {7, 6, 5, 4, 3, 2};


int[]? resArray = DiffElements(array_a, array_b);
if (resArray == null)
{
    Console.WriteLine("Ошибка. Массивы разной длинны!");
    return;
}
Console.WriteLine("["+string.Join(", ",resArray)+"]");
