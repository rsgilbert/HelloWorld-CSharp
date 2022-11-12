using static System.Console;
using static System.Math;
class Program
{
    static void Main(string[] args)
    {
        string? texty2 = null;
        string t3 = texty2!; // null forgiving operator

    
        if(texty2 != null)
        {
            WriteLine($"L is {texty2.Length}");
        }
        WriteLine($"Length is {texty2?.Length ?? -1}");
        // WriteLine($"L2 is {texty2!.Length}");

        var nullableStrings = new string?[5];
        var nonNullableStrings = new string[5];

        WriteLine($"nullable [1] {nullableStrings[1]}");
        WriteLine($"non-nullable [1] {nonNullableStrings[1]}"); 

    }

    public static string Get(IDictionary<int, string> d)
    {
        if(d.TryGetValue(42, out string? s))
        {
            return s;
        }
        return "Not found";
    }
}

public class Counter
{
    private int _count;
    private static int _totalCount;

    public int GetNextValue()
    {
        this._count += 1;
        _totalCount += 1;
        return _count;
    }
    public int Count => _count;

    public static int TotalCount => _totalCount;

    public static int GetTotalCount()
    {
        return _totalCount;
    }

}