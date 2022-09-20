namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<int> Flatten(IEnumerable<int>[] numbers) =>
        numbers.SelectMany(x => x).Distinct();

    public static IEnumerable<int> Divisible(int[] numbers) =>
        numbers.Where(n => n % 7 == 0 && n > 47);
}
