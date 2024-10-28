namespace ConsoleApp.Exstensions;

internal static class ArrayExstension
    
{
    public static int ValueRepeatCount<T>(this T[] arr, T value)
        where T : struct
        //=> arr.Where(e => Equals(e, value)).Count();
    {
        int count = 0;
        foreach (T item in arr)
            if(item.Equals(value))
                count++;

        return count;
    }

    public static T[] UniqueArray<T>(this T[] arr)
        where T : struct
        //=> new HashSet<T>(arr).ToArray();
    {
        T[] newArr = new T[arr.Length];
        int newArrIndex = 0;

        for (int i = 0; i < arr.Length; i++)
            if (!newArr.Contains(arr[i]))
                newArr[newArrIndex++] = arr[i];

        arr = new T[newArrIndex];
        Array.Copy(newArr, arr, newArrIndex);
        return arr;
    }

    public static string ToOutputString<T>(this T[] arr)
        => $"[{string.Join(", ", arr)}]";



}
