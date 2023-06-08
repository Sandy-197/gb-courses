// 3) * Дополнительно * 
// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, 
// и возвращающий новый массив, каждый элемент которого равен частному элементов 
// двух входящих массивов в той же ячейке. 
// Если длины массивов не равны, необходимо как-то оповестить пользователя. 
// Важно: При выполнении метода единственное исключение, 
// которое пользователь может увидеть - RuntimeException, т.е. ваше.

// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, 
// и возвращающий новый массив, 
// каждый элемент которого равен разности элементов двух входящих массивов 
// в той же ячейке. 
// Если длины массивов не равны, необходимо как-то оповестить пользователя.

// Вариант 1. Без прерывания кода. 
// Деление элементов массива. если во втором массиве есть нули. то при деление возникнет исключение. 
// и вернеться null. С сообщением пользователю. Это чтобы код не прерывался.

int[]? DivElements(int[] array_a, int[] array_b)
{
    if (array_a == null || array_b == null || array_a.Length != array_b.Length)
    {
        Console.WriteLine("Ошибка, Массивы разной длинны. Или один из массивов равен null!");
        return null;
    }
    int[]? result = new int[array_a.Length];
    for (int i = 0; i < array_a.Length; i++)
    {
        try
        {
            result[i] = array_a[i] / array_b[i];
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine($"Второй массив содержит элементы равный нулю.\nИндекс элемента {i}.\nДеление на ноль не возможно.");
            return null;
        }
    }
    return result;
}

// Вариант 2. с прерыванием работы кода.
int[]? DivElementsExeption(int[] array_a, int[] array_b)
{
    if (array_a == null || array_b == null || array_a.Length != array_b.Length)
    {
        throw new InvalidOperationException("Ошибка, Массивы разной длинны. Или один из массивов равен null!");
    }
    int[]? result = new int[array_a.Length];
    for (int i = 0; i < array_a.Length; i++)
    {
        try
        {
            result[i] = array_a[i] / array_b[i];
        }
        catch (System.DivideByZeroException)
        {
            throw new DivideByZeroException($"\nВторой массив содержит элементы равный нулю.\nИндекс элемента {i}.\nДеление на ноль не возможно.");
        }
    }
    return result;
}

// Вариант 1
int[] array_a = { 1, 2, 3, 4, 5, 6, 7 };
int[] array_b = { 7, 6, 5, 0, 3, 2, 1 };
Console.WriteLine("Вариант 1.");
int[]? resArray = DivElements(array_a, array_b);
if (resArray == null)
{
    Console.WriteLine("Ошибка. Массивы разной длинны!");
    // return;
}
// else только для того чтобы заработал 2 вариант
else Console.WriteLine("[" + string.Join(", ", resArray) + "]"); 

// Вараинт 2
// Если разная длина вызовет без остановки программы. 
// Если длина одинаковая, 
// но есть ноль во втором  массиве, тогда вызовет ExceptionDivisionByZero.
// можно еще вызвать расширенную информацию если в try использовать переменную для сохранения ошибки.
Console.WriteLine("\nВариант 2.");
int[]? resArray2 = DivElementsExeption(array_a, array_b);
if (resArray == null)
{
    Console.WriteLine("Ошибка. Массивы разной длинны!");
    return;
}
Console.WriteLine("[" + string.Join(", ", resArray2) + "]");