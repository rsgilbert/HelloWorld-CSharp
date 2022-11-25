using static System.Console;
using static System.Math;

public class Program
{


    static void Main(string[] args)
    {
        var greaterThanN = new Predicate<int>[10];
        for (int i = 0; i < greaterThanN.Length; i++)
        {
            var m = i;
            greaterThanN[i] = val =>
            {
                WriteLine($"i is {m}");
                return val > m;
            };
        }

        WriteLine(greaterThanN[2](10));
        WriteLine(greaterThanN[3](1000));

        WriteLine("greaterThanN2");
        var greaterThanN2 = new Predicate<int>[4];
        var arr = new int[] { 0, 1, 2, 3 };
        foreach (var i in arr)
        {
            greaterThanN2[i] = val =>
            {
                WriteLine($"i is {i}");
                return val > i;
            };
        }
        WriteLine(greaterThanN2[1](3));
        WriteLine(greaterThanN2[3](13));

    }

    public static Predicate<int> IsGreaterThan(int threshold)
    {
        return v => v > threshold;
    }

    public static Predicate<int> IsGreaterThan2(int threshold) => val => val > threshold;




}


