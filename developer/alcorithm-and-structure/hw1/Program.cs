// если сортировка по возрастанию тогда sort True, по убыванию False
void sortHeap(int[] array, bool sort=true)
{
    int n = array.Length;

    // Построение кучи (перегруппируем массив)
    for (int i = n / 2 - 1; i >= 0; i--)
         heapify(array, n, i);
    printArray(array);
    // Один за другим извлекаем элементы из кучи
    for (int i = n-1; i >= 0; i--)
    {
        // Перемещаем текущий корень в конец
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;
        heapify(array, i, 0);
        printArray(array);
    }
}

void heapify(int[] array, int n, int i)
{
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    // Если левый дочерний элемент больше корня
    if (left < n && array[left] > array[largest]) largest = left;

    // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
    if (right < n && array[right] > array[largest]) largest = right;

    // Если самый большой элемент не корень
    if (largest != i)
        {
            int temp = array[i];
            array[i] = array[largest];
            array[largest] = temp;
            heapify(array, n, largest);
        }
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}{(i < array.Length - 1 ? ", " : "]")}");
}

int[] array = { 5, 1, 18, 15, 42, 32, 76 };
int n = array.Length;

sortHeap(array);
printArray(array);