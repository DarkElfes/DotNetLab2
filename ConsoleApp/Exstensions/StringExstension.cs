
namespace ConsoleApp.Exstensions;

internal static class StringExstension
{
    public static string Inverse(this string str)
        //=> new string(str.Reverse().ToArray());
        //=> new string(str.ToCharArray().Reverse().ToArray());
    {
        string inverseStr = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
            inverseStr += str[i];

        return inverseStr;
    }


    public static int CountLetter(this string str, char letter)
        //=> str.Where(c => c.Equals(letter)).Count();
    {
        int count = 0;
        foreach (char c in str)
            if (c == letter)
                count++;

        return count;
    }

}
