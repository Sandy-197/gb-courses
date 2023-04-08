public static class ArrayCreator
{
    public static int[] Create(this int n)
    {
        return new int[n];
    }
    public static string ConvertToString(this int[] array)
    {
        return $"[{String.Join(' ', array)}]";
    }

    public static int[] Fill(this int[] array, int min = 0, int max = 10)
    {
        return array.Select(item => Random.Shared.Next(min, max)).ToArray();
    }
}