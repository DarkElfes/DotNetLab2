namespace ConsoleApp.Classes.Extenstions;

internal static class StringExtensions
{
    public static string Inverse(this string str)
    => string.Concat(str.Reverse());

    public static int WordCount(this string str, char c)
        => str.Where(x => x == c).Count();
}
