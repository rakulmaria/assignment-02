namespace Assignment2;
using System.Linq;
using System.Text.RegularExpressions;

public static class Extensions
{
    public static IEnumerable<int> Flatten(IEnumerable<int>[] numbers) =>
        numbers.SelectMany(x => x);

    public static IEnumerable<int> Divisible(int[] numbers) =>
        numbers.Where(n => n % 7 == 0 && n > 47);

    public static bool isSecure(this Uri uri) => uri.ToString().StartsWith("https");

    public static int WordCount(this string str) =>
        Regex.Replace(str, "[0-9]",string.Empty)
        .Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

    public static IEnumerable<int> Leapyear(int[] ys) => ys.Where(n => n%4 == 0 && n%100 != 0 || ( n%400 == 0));
}
