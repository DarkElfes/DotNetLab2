
namespace ConsoleApp.Classes.Extenstions;

public static class ArrayExtensions
{
    public static int ValueCount<T>(this T[] array, T element)
        => array.Where(x => Equals(x, element)).Count();

    public static T[] GetUniqueArray<T>(this T[] array)
        => new HashSet<T>(array).ToArray();
}
