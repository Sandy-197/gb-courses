public static class ArrayMath
{
    public static int GetSym(this int[] array, int m = 3)
    {
        int max = 0;
        int size = array.Length;
        for (int i = 0; i <= size - m; i++)
        {
            int t = 0;
            for (int j = i; j < i + m; j++)
            {
                t += array[j];
            }
        }
        return max;
    }
}