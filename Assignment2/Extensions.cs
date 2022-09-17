namespace Assignment2;
using System.Linq;
using System.Text.RegularExpressions;

public static class Extensions
{
    public static bool isSecure(this Uri uri) => uri.ToString().StartsWith("https");

    public static int WordCount(this string str) =>
        Regex.Replace(str, "[0-9]",string.Empty)
        .Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
}
